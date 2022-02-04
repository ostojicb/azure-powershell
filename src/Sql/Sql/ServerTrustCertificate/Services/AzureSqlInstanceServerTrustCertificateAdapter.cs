﻿using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Sql.ServerTrustCertificate.Model;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Commands.Sql.ServerTrustCertificate.Services
{
    /// <summary>
    /// Adapter for ServerTrustCertificate operations
    /// </summary>
    public class AzureSqlInstanceServerTrustCertificateAdapter
    {
        /// <summary>
        /// Gets or sets the AzureSqlInstanceServerTrustCertificateCommunicator which has all the needed management clients
        /// </summary>
        private AzureSqlInstanceServerTrustCertificateCommunicator Communicator { get; set; }

        /// <summary>
        /// Gets or sets the Azure profile
        /// </summary>
        public IAzureContext Context { get; set; }

        /// <summary>
        /// Constructs a ServerTrustCertificate adapter
        /// </summary>
        /// <param name="context"></param>
        public AzureSqlInstanceServerTrustCertificateAdapter(IAzureContext context)
        {
            Context = context;
            Communicator = new AzureSqlInstanceServerTrustCertificateCommunicator(Context);
        }

        /// <summary>
        /// Gets a server trust certificate in a managed instance
        /// </summary>
        /// <param name="resourceGroupName">The name of the resource group</param>
        /// <param name="managedInstanceName">The name of the managed instance</param>
        /// <param name="certificateName">The name of the certificate</param>
        /// <returns>The managed instance</returns>
        public AzureSqlInstanceServerTrustCertificateModel GetServerTrustCertificate(string resourceGroupName, string managedInstanceName, string certificateName)
        {
            var resp = Communicator.Get(resourceGroupName, managedInstanceName, certificateName);
            return CreateServerTrustCertificateModelFromResponse(resourceGroupName, managedInstanceName, resp);
        }

        /// <summary>
        /// Gets a list of all server trust certificates in managed instance
        /// </summary>
        /// <param name="resourceGroupName"></param>
        /// <param name="managedInstanceName"></param>
        /// <returns>A list of all the server trust certificates</returns>
        public List<AzureSqlInstanceServerTrustCertificateModel> ListServerTrustCertificates(string resourceGroupName, string managedInstanceName)
        {
            var resp = Communicator.List(resourceGroupName, managedInstanceName);

            return resp.Select((cert) => CreateServerTrustCertificateModelFromResponse(resourceGroupName, managedInstanceName, cert)).ToList();
        }

        /// <summary>
        /// Upserts a Server Trust Certificate to Azure SQL Managed Instance
        /// </summary>
        /// <param name="resourceGroup">The name of the resource group</param>
        /// <param name="serverName">The name of the Azure Sql Database Server</param>
        /// <param name="model">The input parameters for the create/update operation</param>
        /// <returns>The upserted Azure Sql Database ElasticPool</returns>
        internal AzureSqlInstanceServerTrustCertificateModel UpsertServerTrustCertificate(AzureSqlInstanceServerTrustCertificateModel model)
        {
            var resp = Communicator.CreateOrUpdate(model.ResourceGroupName, model.ManagedInstanceName, model.CertificateName, new Management.Sql.Models.ServerTrustCertificate
            {
                PublicBlob = model.PublicKey,
            });

            return CreateServerTrustCertificateModelFromResponse(model.ResourceGroupName, model.ManagedInstanceName, resp);
        }

        /// <summary>
        /// Deletes a server trust certificate
        /// </summary>
        /// <param name="resourceGroupName">The resource group the managed instance is in</param>
        /// <param name="managedInstanceName">The name of the managed instance</param>
        /// <param name="certificateName">The name of the certificate to delete</param>
        public void RemoveServerTrustCertificate(string resourceGroupName, string managedInstanceName, string certificateName)
        {
            Communicator.Remove(resourceGroupName, managedInstanceName, certificateName);
        }

        /// <summary>
        /// Convert a Management.Sql.Models.ServerTrustCertificate to AzureSqlInstanceServerTrustCertificateModel
        /// </summary>
        /// <param name="resp">The management client server trust certificate response to convert</param>
        /// <returns>The converted server trust certificate model</returns>
        private static AzureSqlInstanceServerTrustCertificateModel CreateServerTrustCertificateModelFromResponse(string resourceGroupName, string managedInstanceName, Management.Sql.Models.ServerTrustCertificate serverTrustCertificate)
        {
            AzureSqlInstanceServerTrustCertificateModel serverTrustCertificateModel = new AzureSqlInstanceServerTrustCertificateModel()
            {
                ResourceGroupName = resourceGroupName,
                ManagedInstanceName = managedInstanceName,
                CertificateName = serverTrustCertificate.CertificateName,
                PublicKey = serverTrustCertificate.PublicBlob,
                Thumbprint = serverTrustCertificate.Thumbprint
            };
            return serverTrustCertificateModel;
        }
    }
}
