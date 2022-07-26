// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A remove disk(s) input.</summary>
    public partial class A2ARemoveDisksInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ARemoveDisksInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ARemoveDisksInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksProviderSpecificInput __removeDisksProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RemoveDisksProviderSpecificInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksProviderSpecificInputInternal)__removeDisksProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksProviderSpecificInputInternal)__removeDisksProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="VMDisksUri" /> property.</summary>
        private string[] _vMDisksUri;

        /// <summary>The list of vm disk vhd URIs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] VMDisksUri { get => this._vMDisksUri; set => this._vMDisksUri = value; }

        /// <summary>Backing field for <see cref="VMManagedDisksId" /> property.</summary>
        private string[] _vMManagedDisksId;

        /// <summary>The list of vm managed disk Ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] VMManagedDisksId { get => this._vMManagedDisksId; set => this._vMManagedDisksId = value; }

        /// <summary>Creates an new <see cref="A2ARemoveDisksInput" /> instance.</summary>
        public A2ARemoveDisksInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__removeDisksProviderSpecificInput), __removeDisksProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__removeDisksProviderSpecificInput), __removeDisksProviderSpecificInput);
        }
    }
    /// A2A remove disk(s) input.
    public partial interface IA2ARemoveDisksInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksProviderSpecificInput
    {
        /// <summary>The list of vm disk vhd URIs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of vm disk vhd URIs.",
        SerializedName = @"vmDisksUris",
        PossibleTypes = new [] { typeof(string) })]
        string[] VMDisksUri { get; set; }
        /// <summary>The list of vm managed disk Ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of vm managed disk Ids.",
        SerializedName = @"vmManagedDisksIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] VMManagedDisksId { get; set; }

    }
    /// A2A remove disk(s) input.
    internal partial interface IA2ARemoveDisksInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRemoveDisksProviderSpecificInputInternal
    {
        /// <summary>The list of vm disk vhd URIs.</summary>
        string[] VMDisksUri { get; set; }
        /// <summary>The list of vm managed disk Ids.</summary>
        string[] VMManagedDisksId { get; set; }

    }
}