// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Extensions;

    /// <summary>The resource usages value.</summary>
    public partial class UsagesObject :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IUsagesObject,
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IUsagesObjectInternal
    {

        /// <summary>Backing field for <see cref="UsagesType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.UsagesTypes? _usagesType;

        /// <summary>The quota or usages limit types.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.UsagesTypes? UsagesType { get => this._usagesType; set => this._usagesType = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private int _value;

        /// <summary>The usages value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public int Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="UsagesObject" /> instance.</summary>
        public UsagesObject()
        {

        }
    }
    /// The resource usages value.
    public partial interface IUsagesObject :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.IJsonSerializable
    {
        /// <summary>The quota or usages limit types.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The quota or usages limit types.",
        SerializedName = @"usagesType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.UsagesTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.UsagesTypes? UsagesType { get; set; }
        /// <summary>The usages value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The usages value.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(int) })]
        int Value { get; set; }

    }
    /// The resource usages value.
    internal partial interface IUsagesObjectInternal

    {
        /// <summary>The quota or usages limit types.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Support.UsagesTypes? UsagesType { get; set; }
        /// <summary>The usages value.</summary>
        int Value { get; set; }

    }
}