// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>Query approved plans response</summary>
    public partial class QueryApprovedPlansResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IQueryApprovedPlansResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IQueryApprovedPlansResponseInternal
    {

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IQueryApprovedPlansDetails> _detail;

        /// <summary>
        /// A list indicating for each plan which subscriptions are approved. Plan Id is unique
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IQueryApprovedPlansDetails> Detail { get => this._detail; set => this._detail = value; }

        /// <summary>Creates an new <see cref="QueryApprovedPlansResponse" /> instance.</summary>
        public QueryApprovedPlansResponse()
        {

        }
    }
    /// Query approved plans response
    public partial interface IQueryApprovedPlansResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A list indicating for each plan which subscriptions are approved. Plan Id is unique
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list indicating for each plan which subscriptions are approved. Plan Id is unique",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IQueryApprovedPlansDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IQueryApprovedPlansDetails> Detail { get; set; }

    }
    /// Query approved plans response
    internal partial interface IQueryApprovedPlansResponseInternal

    {
        /// <summary>
        /// A list indicating for each plan which subscriptions are approved. Plan Id is unique
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IQueryApprovedPlansDetails> Detail { get; set; }

    }
}