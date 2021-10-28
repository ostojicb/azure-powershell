// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>alternativeSecurityId</summary>
    public partial class MicrosoftGraphAlternativeSecurityId :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAlternativeSecurityId,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAlternativeSecurityIdInternal
    {

        /// <summary>Backing field for <see cref="IdentityProvider" /> property.</summary>
        private string _identityProvider;

        /// <summary>For internal use only</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string IdentityProvider { get => this._identityProvider; set => this._identityProvider = value; }

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private byte[] _key;

        /// <summary>For internal use only</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public byte[] Key { get => this._key; set => this._key = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private int? _type;

        /// <summary>For internal use only</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public int? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphAlternativeSecurityId" /> instance.</summary>
        public MicrosoftGraphAlternativeSecurityId()
        {

        }
    }
    /// alternativeSecurityId
    public partial interface IMicrosoftGraphAlternativeSecurityId :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>For internal use only</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"For internal use only",
        SerializedName = @"identityProvider",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityProvider { get; set; }
        /// <summary>For internal use only</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"For internal use only",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(byte[]) })]
        byte[] Key { get; set; }
        /// <summary>For internal use only</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"For internal use only",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(int) })]
        int? Type { get; set; }

    }
    /// alternativeSecurityId
    internal partial interface IMicrosoftGraphAlternativeSecurityIdInternal

    {
        /// <summary>For internal use only</summary>
        string IdentityProvider { get; set; }
        /// <summary>For internal use only</summary>
        byte[] Key { get; set; }
        /// <summary>For internal use only</summary>
        int? Type { get; set; }

    }
}