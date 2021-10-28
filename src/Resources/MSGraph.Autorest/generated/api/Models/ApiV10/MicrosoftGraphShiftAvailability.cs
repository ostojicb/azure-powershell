// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>shiftAvailability</summary>
    public partial class MicrosoftGraphShiftAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphShiftAvailability,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphShiftAvailabilityInternal
    {

        /// <summary>Backing field for <see cref="Recurrence" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPatternedRecurrence _recurrence;

        /// <summary>patternedRecurrence</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPatternedRecurrence Recurrence { get => (this._recurrence = this._recurrence ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphPatternedRecurrence()); set => this._recurrence = value; }

        /// <summary>Backing field for <see cref="TimeSlot" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphTimeRange[] _timeSlot;

        /// <summary>The time slot(s) preferred by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphTimeRange[] TimeSlot { get => this._timeSlot; set => this._timeSlot = value; }

        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private string _timeZone;

        /// <summary>Specifies the time zone for the indicated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string TimeZone { get => this._timeZone; set => this._timeZone = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphShiftAvailability" /> instance.</summary>
        public MicrosoftGraphShiftAvailability()
        {

        }
    }
    /// shiftAvailability
    public partial interface IMicrosoftGraphShiftAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>patternedRecurrence</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"patternedRecurrence",
        SerializedName = @"recurrence",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPatternedRecurrence) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPatternedRecurrence Recurrence { get; set; }
        /// <summary>The time slot(s) preferred by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time slot(s) preferred by the user.",
        SerializedName = @"timeSlots",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphTimeRange) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphTimeRange[] TimeSlot { get; set; }
        /// <summary>Specifies the time zone for the indicated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the time zone for the indicated time.",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZone { get; set; }

    }
    /// shiftAvailability
    internal partial interface IMicrosoftGraphShiftAvailabilityInternal

    {
        /// <summary>patternedRecurrence</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPatternedRecurrence Recurrence { get; set; }
        /// <summary>The time slot(s) preferred by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphTimeRange[] TimeSlot { get; set; }
        /// <summary>Specifies the time zone for the indicated time.</summary>
        string TimeZone { get; set; }

    }
}