﻿using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Sql.ManagedInstance.Model;
using Microsoft.Azure.Commands.Sql.ServerTrustCertificate.Model;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Sql.ServerTrustCertificate.Cmdlet
{

    /// <summary>
    /// Cmdlet to get a new Server Trust certificate
    /// </summary>
    [Cmdlet(
        VerbsCommon.Get, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "SqlInstanceServerTrustCertificate",
        DefaultParameterSetName = GetByNameParameterSet
        ), 
        OutputType(typeof(AzureSqlInstanceServerTrustCertificateModel))]
    public class GetAzureSqlInstanceServerTrustCertificate : AzureSqlInstanceServerTrustCertificateCmdletBase
    {
        private const string GetByNameParameterSet = "GetByNameParameterSet";
        private const string GetByParentObjectParameterSet = "GetByParentObjectParameterSet";
        private const string GetByResourceIdParameterSet = "GetByResourceIdParameterSet";
        private const string GetByInstanceResourceIdParameterSet = "GetByInstanceResourceIdParameterSet";

        /// <summary>
        /// Gets or sets the name of the resource group to use.
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = GetByNameParameterSet, Position = 0, HelpMessage = "The name of the resource group.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public override string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the name of target managed instance
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = GetByNameParameterSet, Position = 1, HelpMessage = "The name of the Azure SQL Managed Instance.")]
        [ResourceNameCompleter("Microsoft.Sql/managedInstances", nameof(ResourceGroupName))]
        [ValidateNotNullOrEmpty]
        public string InstanceName { get; set; }

        /// <summary>
        /// Gets or sets the certificate name
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = GetByNameParameterSet, Position = 2, HelpMessage = "The name of the certificate.")]
        [Parameter(Mandatory = false, ParameterSetName = GetByParentObjectParameterSet, Position = 1, HelpMessage = "The name of the certificate.")]
        [Parameter(Mandatory = false, ParameterSetName = GetByInstanceResourceIdParameterSet, Position = 1, HelpMessage = "The name of the certificate.")]
        [ResourceNameCompleter("Microsoft.Sql/managedInstances/serverTrustCertificates", nameof(ResourceGroupName), nameof(InstanceName))]
        [ValidateNotNullOrEmpty]
        public string CertificateName { get; set; }

        /// <summary>
        /// Gets or sets the instance Object
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = GetByParentObjectParameterSet, ValueFromPipeline = true, Position = 0, HelpMessage = "The instance input object.")]
        [ValidateNotNullOrEmpty]
        public AzureSqlManagedInstanceModel Instance { get; set; }

        /// <summary>
        /// Gets or sets the certificate Resource Id
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = GetByResourceIdParameterSet, ValueFromPipelineByPropertyName = true, Position = 0, HelpMessage = "The certificate resource id.")]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the instance Resource Id
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = GetByInstanceResourceIdParameterSet, ValueFromPipelineByPropertyName = true, Position = 0, HelpMessage = "The managed instance resource id.")]
        [ValidateNotNullOrEmpty]
        public string InstanceResourceId { get; set; }

        /// <summary>
        /// Entry point for the cmdlet
        /// </summary>
        public override void ExecuteCmdlet()
        {    
            switch (ParameterSetName)
            {
                case GetByNameParameterSet:
                    // default case, we're getting RG, MI and Cert names directly from args
                    break;
                case GetByParentObjectParameterSet:
                    // we need to extract RG and MI name from the Instance object, Cert name received directly from arg
                    ResourceGroupName = Instance.ResourceGroupName;
                    InstanceName = Instance.ManagedInstanceName;
                    break;
                case GetByResourceIdParameterSet:
                    // we need to derive RG, MI and Cert name from resource id
                    var resourceInfo = new ResourceIdentifier(ResourceId);
                    ResourceGroupName = resourceInfo.ResourceGroupName;
                    InstanceName = resourceInfo.ParentResource.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
                    CertificateName = resourceInfo.ResourceName;
                    break;
                case GetByInstanceResourceIdParameterSet:
                    // we need to derive RG and MI name from managed instance resource id, cert name passed from arg
                    var instanceInfo = new ResourceIdentifier(InstanceResourceId);
                    ResourceGroupName = instanceInfo.ResourceGroupName;
                    InstanceName = instanceInfo.ResourceName;
                    break;
                default:
                    break;
            }
            base.ExecuteCmdlet();
        }

        /// <summary>
        /// Gets the certificate if name is passed, otherwise list all available certificates on the managed instance
        /// </summary>
        /// <returns>The list of entities</returns>
        protected override IEnumerable<AzureSqlInstanceServerTrustCertificateModel> GetEntity()
        {
            ICollection<AzureSqlInstanceServerTrustCertificateModel> results = new List<AzureSqlInstanceServerTrustCertificateModel>();
            if (CertificateName != null)
            {
                results.Add(ModelAdapter.GetServerTrustCertificate(ResourceGroupName, InstanceName, CertificateName));
            }
            else
            {
                results = ModelAdapter.ListServerTrustCertificates(ResourceGroupName, InstanceName);
            }
            return results;
        }

        /// <summary>
        /// No changes, thus nothing to persist.
        /// </summary>
        /// <param name="entity">The entity retrieved</param>
        /// <returns>The unchanged entity</returns>
        protected override IEnumerable<AzureSqlInstanceServerTrustCertificateModel> PersistChanges(IEnumerable<AzureSqlInstanceServerTrustCertificateModel> entity)
        {
            return entity;
        }

        /// <summary>
        /// No user input to apply to model.
        /// </summary>
        /// <param name="model">The model to modify</param>
        /// <returns>The input model</returns>
        protected override IEnumerable<AzureSqlInstanceServerTrustCertificateModel> ApplyUserInputToModel(IEnumerable<AzureSqlInstanceServerTrustCertificateModel> model)
        {
            return model;
        }
    }
}
