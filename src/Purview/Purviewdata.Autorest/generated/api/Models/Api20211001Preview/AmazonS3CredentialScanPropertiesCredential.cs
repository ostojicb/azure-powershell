// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class AmazonS3CredentialScanPropertiesCredential :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3CredentialScanPropertiesCredential,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3CredentialScanPropertiesCredentialInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReference"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReference __credentialReference = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.CredentialReference();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType? CredentialType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReferenceInternal)__credentialReference).CredentialType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReferenceInternal)__credentialReference).CredentialType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType)""); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReferenceInternal)__credentialReference).ReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReferenceInternal)__credentialReference).ReferenceName = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="AmazonS3CredentialScanPropertiesCredential" /> instance.
        /// </summary>
        public AmazonS3CredentialScanPropertiesCredential()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__credentialReference), __credentialReference);
            await eventListener.AssertObjectIsValid(nameof(__credentialReference), __credentialReference);
        }
    }
    public partial interface IAmazonS3CredentialScanPropertiesCredential :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReference
    {

    }
    internal partial interface IAmazonS3CredentialScanPropertiesCredentialInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReferenceInternal
    {

    }
}