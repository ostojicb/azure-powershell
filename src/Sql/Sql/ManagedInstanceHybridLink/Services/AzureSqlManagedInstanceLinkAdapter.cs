﻿using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Sql.ManagedInstanceHybridLink.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Azure.Commands.Sql.ManagedInstanceHybridLink.Services
{
    /// <summary>
    /// Adapter for ManagedInstanceLink operations
    /// </summary>
    public class AzureSqlManagedInstanceLinkAdapter
    {
        /// <summary>
        /// Gets or sets the AzureSqlManagedInstanceLinkCommunicator which has all the needed management clients
        /// </summary>
        private AzureSqlManagedInstanceLinkCommunicator Communicator { get; set; }

        /// <summary>
        /// Gets or sets the Azure profile
        /// </summary>
        public IAzureContext Context { get; set; }

        /// <summary>
        /// Constructs a ManagedInstanceLink adapter
        /// </summary>
        /// <param name="context"></param>
        public AzureSqlManagedInstanceLinkAdapter(IAzureContext context)
        {
            Context = context;
            Communicator = new AzureSqlManagedInstanceLinkCommunicator(Context);
        }

        /// <summary>
        /// Gets a managed instance link in a managed instance
        /// </summary>
        /// <param name="resourceGroupName">The name of the resource group</param>
        /// <param name="managedInstanceName">The name of the managed instance</param>
        /// <param name="distributedAvailabilityGroupName">The name of the DAG</param>
        /// <returns>The managed instance link</returns>
        public AzureSqlManagedInstanceLinkModel GetManagedInstanceLink(string resourceGroupName, string managedInstanceName, string distributedAvailabilityGroupName)
        {
            var resp = Communicator.Get(resourceGroupName, managedInstanceName, distributedAvailabilityGroupName);
            return CreateManagedInstanceLinkModelFromResponse(resourceGroupName, managedInstanceName, resp);
        }

        /// <summary>
        /// Gets a list of all distributed availiability groups in managed instance
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="managedInstanceName"></param>
        /// <returns>A list of all the server trust certificates</returns>
        public List<AzureSqlManagedInstanceLinkModel> ListManagedInstanceLinks(string resourceGroupName, string managedInstanceName)
        {
            var resp = Communicator.List(resourceGroupName, managedInstanceName);

            return resp.Select((dag) => CreateManagedInstanceLinkModelFromResponse(resourceGroupName, managedInstanceName, dag)).ToList();
        }

        /// <summary>
        /// Creates a new managed instance link
        /// </summary>
        /// <param name="model">The input parameters for the create/update operation</param>
        /// <returns>The upserted Azure Sql Managed Instance Link</returns>
        internal AzureSqlManagedInstanceLinkModel CreateManagedInstanceLink(AzureSqlManagedInstanceLinkModel model)
        {
            var resp = Communicator.CreateOrUpdate(model.ResourceGroupName, model.ManagedInstanceName, model.DistributedAvailabilityGroupName, new Management.Sql.Models.DistributedAvailabilityGroup
            {
                TargetDatabase = model.TargetDatabase,
                SourceEndpoint = model.SourceEndpoint, 
                PrimaryAvailabilityGroupName = model.PrimaryAvailabilityGroupName,
                SecondaryAvailabilityGroupName = model.SecondaryAvailabilityGroupName,
            });

            return CreateManagedInstanceLinkModelFromResponse(model.ResourceGroupName, model.ManagedInstanceName, resp);
        }

        /// <summary>
        /// Updates managed instance link
        /// </summary>
        /// <param name="model">The input parameters for the update operation</param>
        /// <returns>The updated Azure Sql Managed Instance Link</returns>
        internal AzureSqlManagedInstanceLinkModel UpdateManagedInstanceLink(AzureSqlManagedInstanceLinkModel model)
        {
            var resp = Communicator.Update(model.ResourceGroupName, model.ManagedInstanceName, model.DistributedAvailabilityGroupName, new Management.Sql.Models.DistributedAvailabilityGroup
            {
                ReplicationMode = model.ReplicationMode,
            });

            return CreateManagedInstanceLinkModelFromResponse(model.ResourceGroupName, model.ManagedInstanceName, resp);
        }

        /// <summary>
        /// Deletes a managed instance link
        /// </summary>
        /// <param name="resourceGroupName">The resource group the managed instance is in</param>
        /// <param name="managedInstanceName">The name of the managed instance</param>
        /// <param name="managedInstanceLinkName">The name of the MI Link to delete</param>
        public void RemoveManagedInstanceLink(string resourceGroupName, string managedInstanceName, string managedInstanceLinkName)
        {
            Communicator.Remove(resourceGroupName, managedInstanceName, managedInstanceLinkName);
        }

        /// <summary>
        /// Convert a Management.Sql.Models.DistributedAvailabilityGroup to AzureSqlManagedInstanceLinkModel
        /// </summary>
        /// <param name="resp">The management client distributed availiability group response to convert</param>
        /// <returns>The converted managed instance link model</returns>
        private static AzureSqlManagedInstanceLinkModel CreateManagedInstanceLinkModelFromResponse(string resourceGroupName, string managedInstanceName, Management.Sql.Models.DistributedAvailabilityGroup managedInstanceLink)
        {
            AzureSqlManagedInstanceLinkModel managedInstanceLinkModel = new AzureSqlManagedInstanceLinkModel()
            {
                ResourceGroupName = resourceGroupName,
                ManagedInstanceName = managedInstanceName,
                //DistributedAvailabilityGroupName = distributedAvailabilityGroupName,
                TargetDatabase = managedInstanceLink.TargetDatabase,
                SourceEndpoint = managedInstanceLink.SourceEndpoint,
                ReplicationMode = managedInstanceLink.ReplicationMode,
                //PrimaryAvailabilityGroupName = managedInstanceLink.PrimaryAvailabilityGroupName,
                //SecondaryAvailabilityGroupName = managedInstanceLink.SecondaryAvailabilityGroupName,
                DistributedAvailabilityGroupId = managedInstanceLink.DistributedAvailabilityGroupId,
                SourceReplicaId = managedInstanceLink.SourceReplicaId,
                TargetReplicaId = managedInstanceLink.TargetReplicaId,
                LinkState = managedInstanceLink.LinkState,
                LastHardenedLsn =managedInstanceLink.LastHardenedLsn,
            };
            return managedInstanceLinkModel;
        }
    }
}
