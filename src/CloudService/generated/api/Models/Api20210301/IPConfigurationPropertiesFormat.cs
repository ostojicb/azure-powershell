// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Properties of IP configuration.</summary>
    public partial class IPConfigurationPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPConfigurationPropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPConfigurationPropertiesFormatInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPConfigurationPropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PrivateIPAddress" /> property.</summary>
        private string _privateIPAddress;

        /// <summary>The private IP address of the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string PrivateIPAddress { get => this._privateIPAddress; set => this._privateIPAddress = value; }

        /// <summary>Backing field for <see cref="PrivateIPAllocationMethod" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod? _privateIPAllocationMethod;

        /// <summary>The private IP address allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod? PrivateIPAllocationMethod { get => this._privateIPAllocationMethod; set => this._privateIPAllocationMethod = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the IP configuration resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicIPAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress _publicIPAddress;

        /// <summary>The reference to the public IP resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress PublicIPAddress { get => (this._publicIPAddress = this._publicIPAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddress()); set => this._publicIPAddress = value; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet _subnet;

        /// <summary>The reference to the subnet resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.Subnet()); set => this._subnet = value; }

        /// <summary>Creates an new <see cref="IPConfigurationPropertiesFormat" /> instance.</summary>
        public IPConfigurationPropertiesFormat()
        {

        }
    }
    /// Properties of IP configuration.
    public partial interface IIPConfigurationPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>The private IP address of the IP configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private IP address of the IP configuration.",
        SerializedName = @"privateIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateIPAddress { get; set; }
        /// <summary>The private IP address allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private IP address allocation method.",
        SerializedName = @"privateIPAllocationMethod",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary>The provisioning state of the IP configuration resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the IP configuration resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The reference to the public IP resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reference to the public IP resource.",
        SerializedName = @"publicIPAddress",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress PublicIPAddress { get; set; }
        /// <summary>The reference to the subnet resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reference to the subnet resource.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet Subnet { get; set; }

    }
    /// Properties of IP configuration.
    internal partial interface IIPConfigurationPropertiesFormatInternal

    {
        /// <summary>The private IP address of the IP configuration.</summary>
        string PrivateIPAddress { get; set; }
        /// <summary>The private IP address allocation method.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary>The provisioning state of the IP configuration resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The reference to the public IP resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress PublicIPAddress { get; set; }
        /// <summary>The reference to the subnet resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet Subnet { get; set; }

    }
}