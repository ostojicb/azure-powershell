// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support
{

    /// <summary>
    /// Location in which the Resources needs to be reserved. It cannot be changed after the resource has been created.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.LocationTypeConverter))]
    public partial struct Location :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "westus".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'westus'", "westus", global::System.Management.Automation.CompletionResultType.ParameterValue, "westus");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "eastus".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'eastus'", "eastus", global::System.Management.Automation.CompletionResultType.ParameterValue, "eastus");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "eastus2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'eastus2'", "eastus2", global::System.Management.Automation.CompletionResultType.ParameterValue, "eastus2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "northcentralus".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'northcentralus'", "northcentralus", global::System.Management.Automation.CompletionResultType.ParameterValue, "northcentralus");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "westus2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'westus2'", "westus2", global::System.Management.Automation.CompletionResultType.ParameterValue, "westus2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "southcentralus".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'southcentralus'", "southcentralus", global::System.Management.Automation.CompletionResultType.ParameterValue, "southcentralus");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "centralus".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'centralus'", "centralus", global::System.Management.Automation.CompletionResultType.ParameterValue, "centralus");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "westeurope".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'westeurope'", "westeurope", global::System.Management.Automation.CompletionResultType.ParameterValue, "westeurope");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "northeurope".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'northeurope'", "northeurope", global::System.Management.Automation.CompletionResultType.ParameterValue, "northeurope");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "eastasia".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'eastasia'", "eastasia", global::System.Management.Automation.CompletionResultType.ParameterValue, "eastasia");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "southeastasia".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'southeastasia'", "southeastasia", global::System.Management.Automation.CompletionResultType.ParameterValue, "southeastasia");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "japaneast".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'japaneast'", "japaneast", global::System.Management.Automation.CompletionResultType.ParameterValue, "japaneast");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "japanwest".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'japanwest'", "japanwest", global::System.Management.Automation.CompletionResultType.ParameterValue, "japanwest");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "brazilsouth".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'brazilsouth'", "brazilsouth", global::System.Management.Automation.CompletionResultType.ParameterValue, "brazilsouth");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "australiaeast".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'australiaeast'", "australiaeast", global::System.Management.Automation.CompletionResultType.ParameterValue, "australiaeast");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "australiasoutheast".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'australiasoutheast'", "australiasoutheast", global::System.Management.Automation.CompletionResultType.ParameterValue, "australiasoutheast");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "southindia".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'southindia'", "southindia", global::System.Management.Automation.CompletionResultType.ParameterValue, "southindia");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "westindia".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'westindia'", "westindia", global::System.Management.Automation.CompletionResultType.ParameterValue, "westindia");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "centralindia".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'centralindia'", "centralindia", global::System.Management.Automation.CompletionResultType.ParameterValue, "centralindia");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "canadacentral".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'canadacentral'", "canadacentral", global::System.Management.Automation.CompletionResultType.ParameterValue, "canadacentral");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "canadaeast".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'canadaeast'", "canadaeast", global::System.Management.Automation.CompletionResultType.ParameterValue, "canadaeast");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "uksouth".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'uksouth'", "uksouth", global::System.Management.Automation.CompletionResultType.ParameterValue, "uksouth");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "westcentralus".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'westcentralus'", "westcentralus", global::System.Management.Automation.CompletionResultType.ParameterValue, "westcentralus");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ukwest".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ukwest'", "ukwest", global::System.Management.Automation.CompletionResultType.ParameterValue, "ukwest");
            }
        }
    }
}