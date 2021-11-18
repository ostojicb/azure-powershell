// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Hyak.Common;
using Microsoft.Azure.Commands.ActiveDirectory;
using Microsoft.Azure.Management.Authorization.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using ProjectResources = Microsoft.Azure.Commands.Resources.Properties.Resources;

namespace Microsoft.Azure.Commands.Resources.Models.Authorization
{
    internal static class AuthorizationClientExtensions
    {
        private const string AllPrincipals = "All Principals";
        private const string SystemDefined = "SystemDefined";
        public const string CustomRole = "CustomRole";
        public const string DeletedObject = "Unknown";

        public static IEnumerable<RoleAssignment> FilterRoleAssignmentsOnRoleId(this IEnumerable<RoleAssignment> assignments, string roleId)
        {
            if (!string.IsNullOrEmpty(roleId))
            {
                return assignments.Where(a => a.RoleDefinitionId.GuidFromFullyQualifiedId() == roleId.GuidFromFullyQualifiedId());
            }

            return assignments;
        }

        public static PSRoleDefinition ToPSRoleDefinition(this RoleDefinition role)
        {
            PSRoleDefinition roleDefinition = null;

            if (role != null)
            {
                roleDefinition = new PSRoleDefinition
                {
                    Name = role.RoleName,
                    Actions = new List<string>(role.Permissions.SelectMany(r => r.Actions)),
                    NotActions = new List<string>(role.Permissions.SelectMany(r => r.NotActions)),
                    DataActions = new List<string>(role.Permissions.SelectMany(r => r.DataActions)),
                    NotDataActions = new List<string>(role.Permissions.SelectMany(r => r.NotDataActions)),
                    Id = role.Id.GuidFromFullyQualifiedId(),
                    AssignableScopes = role.AssignableScopes.ToList(),
                    Description = role.Description,
                    IsCustom = role.RoleType == CustomRole ? true : false
                };
            }

            return roleDefinition;
        }

        public static PSRoleAssignment ToPSRoleAssignment(this RoleAssignment assignment, AuthorizationClient policyClient, ActiveDirectoryClient activeDirectoryClient, string scopeForRoleDefinition = null)
        {
            PSRoleDefinition roleDefinition = null;
            PSADObject adObject = null;

            // Get role definition name information by role definition ID
            try
            {
                if (string.IsNullOrEmpty(scopeForRoleDefinition))
                {
                    roleDefinition = policyClient.GetRoleDefinition(assignment.RoleDefinitionId);
                }
                else
                {
                    roleDefinition = policyClient.GetRoleDefinition(assignment.RoleDefinitionId.GetGuidFromId(), scopeForRoleDefinition);
                } 
            }
            catch (CloudException ce) when(ce.Response.StatusCode == HttpStatusCode.Unauthorized)
            {
                //Swallow unauthorized errors on RoleDefinition when displaying RoleAssignments
            }

            // Get principal type by principal ID
            try
            {
                if (string.IsNullOrEmpty(assignment.PrincipalType))
                {
                    adObject = activeDirectoryClient.GetObjectByObjectId(assignment.PrincipalId);
                }
            }
            catch
            {
                //Swallow exceptions when displaying active directive object
            }

            return new PSRoleAssignment()
            {
                RoleAssignmentId = assignment.Id,
                Scope = assignment.Scope,
                DisplayName = assignment.Name,
                SignInName = adObject is PSADUser user ? user.UserPrincipalName : null,
                RoleDefinitionName = roleDefinition?.Name,
                RoleDefinitionId = assignment.RoleDefinitionId,
                ObjectId = assignment.PrincipalId,
                ObjectType = string.IsNullOrEmpty(assignment.PrincipalType)? adObject?.Type : assignment.PrincipalType,
                // CanDelegate's value is absent from RoleAssignment
                // CanDelegate = null,
                Description = assignment.Description,
                ConditionVersion = assignment.ConditionVersion,
                Condition = assignment.Condition
            };
        }


        /// <summary>
        /// Convert classic administrator to PSRoleAssignment
        /// </summary>
        /// <param name="classicAdministrator">Current classic administrator</param>
        /// <param name="currentSubscriptionId">Current subscription id</param>
        /// <returns></returns>
        public static PSRoleAssignment ToPSRoleAssignment(this ClassicAdministrator classicAdministrator, string currentSubscriptionId)
        {
            return new PSRoleAssignment()
            {
                RoleDefinitionName = classicAdministrator.Role,
                DisplayName = classicAdministrator.EmailAddress,
                SignInName = classicAdministrator.EmailAddress,
                Scope = AuthorizationHelper.GetSubscriptionScope(currentSubscriptionId),
                ObjectType = classicAdministrator.Type ?? "User"
            };
        }

        public static PSDenyAssignment ToPSDenyAssignment(this DenyAssignment assignment, ActiveDirectoryClient activeDirectoryClient)
        {
            var psda = new PSDenyAssignment()
            {
                Id = assignment.Id,
                DenyAssignmentName = assignment.DenyAssignmentName,
                Description = assignment.Description,
                Actions = new List<string>(assignment.Permissions.SelectMany(p => p.Actions)),
                NotActions = new List<string>(assignment.Permissions.SelectMany(p => p.NotActions)),
                DataActions = new List<string>(assignment.Permissions.SelectMany(p => p.DataActions)),
                NotDataActions = new List<string>(assignment.Permissions.SelectMany(p => p.NotDataActions)),
                Scope = assignment.Scope,
                DoNotApplyToChildScopes = assignment.DoNotApplyToChildScopes ?? false,
                IsSystemProtected = assignment.IsSystemProtected ?? false,
            };

            // Get principal's display name information
            psda.Principals = assignment.Principals.Select(p => p.ToPSPrincipal(activeDirectoryClient)).ToList();
            psda.ExcludePrincipals = assignment.ExcludePrincipals.Select(p => p.ToPSPrincipal(activeDirectoryClient)).ToList();

            return psda;
        }

        /// <summary>
        /// Convert Principal to PSPrincipal, try to get display name if client is provided and authorization is allowed
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="activeDirectoryClient"></param>
        /// <returns></returns>
        private static PSPrincipal ToPSPrincipal(this Principal principal, ActiveDirectoryClient activeDirectoryClient = null)
        {
            if (Guid.Parse(principal.Id) == Guid.Empty)
            {
                return new PSPrincipal { DisplayName = AllPrincipals, ObjectType = SystemDefined, ObjectId = new Guid(principal.Id) };
            }

            PSADObject adObject = null;
            try
            {
                adObject = activeDirectoryClient?.GetObjectByObjectId(principal.Id);
            }
            catch 
            {
                // Swallow exception
            }
            return new PSPrincipal
            {
                DisplayName = adObject?.DisplayName,
                ObjectType = principal.Type,
                ObjectId = new Guid(principal.Id)
            };
        }
    }
}
