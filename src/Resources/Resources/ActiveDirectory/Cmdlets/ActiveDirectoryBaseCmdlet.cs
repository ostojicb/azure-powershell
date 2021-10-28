﻿// ----------------------------------------------------------------------------------
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

using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.Azure.Graph.RBAC.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System;
using System.Management.Automation;
using System.Net;
using ProjectResources = Microsoft.Azure.Commands.Resources.Properties.Resources;

namespace Microsoft.Azure.Commands.ActiveDirectory
{
    [GenericBreakingChange("This cmdlet will use Microsoft Graph in Az 7.x and later., Visit https://go.microsoft.com/fwlink/?linkid=2174792 for migration guide and breaking changes.")]
    public abstract class ActiveDirectoryBaseCmdlet : AzureRMCmdlet
    {
        private ActiveDirectoryClient _activeDirectoryClient;

        public ActiveDirectoryClient ActiveDirectoryClient
        {
            get
            {
                if (_activeDirectoryClient == null)
                {
                    _activeDirectoryClient = new ActiveDirectoryClient(DefaultProfile.DefaultContext);
                }

                return _activeDirectoryClient;
            }

            set { _activeDirectoryClient = value; }
        }

        /// <summary>
        /// Handles graph exceptions thrown by client
        /// </summary>
        /// <param name="exception"></param>
        private void HandleException(Exception exception)
        {
            Exception targetEx = exception;
            string targetErrorId = String.Empty;
            ErrorCategory targetErrorCategory = ErrorCategory.NotSpecified;
            var graphEx = exception as GraphErrorException;

            if (graphEx == null)
            {
                throw exception;
            }

            if (graphEx.Body != null && graphEx.Body.Message != null && graphEx.Body.Code != null)
            {
                WriteDebug(String.Format(ProjectResources.GraphException, graphEx.Body.Code, graphEx.Body.Message));
                targetEx = new Exception(graphEx.Body.Message);
                targetErrorId = graphEx.Body.Code;
            }
            else
            {
                if (graphEx.Response != null && graphEx.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    targetErrorCategory = ErrorCategory.InvalidArgument;
                }
                else
                {
                    targetErrorCategory = ErrorCategory.InvalidOperation;
                }

                Exception parsedException = ParseResponse(graphEx);
                targetEx = parsedException ?? targetEx;
            }

            var errorRecord = new ErrorRecord(targetEx, targetErrorId, targetErrorCategory, null);
            WriteError(errorRecord);
        }


        private Exception ParseResponse(GraphErrorException graphEx)
        {
            if (graphEx?.Response?.Content != null)
            {
                int exceptionMessageIndex = graphEx.Response.Content.IndexOf("\"value\":", StringComparison.CurrentCultureIgnoreCase);
                if (exceptionMessageIndex > 0)
                {
                    string substring = graphEx.Response.Content.Substring(exceptionMessageIndex + 9);
                    // the start index is added 9, so as to remove the delimiter \"value\":\
                    string exceptionDetails = substring.Substring(0, substring.IndexOf("\"}"));
                    return new Exception(exceptionDetails);
                }
            }

            return null;
        }

        protected void ExecutionBlock(Action execAction)
        {
            try
            {
                execAction();
            }
            catch (Exception exception)
            {
                WriteDebug(String.Format(ProjectResources.ExceptionInExecution, exception.GetType()));
                HandleException(exception);
            }
        }
    }
}
