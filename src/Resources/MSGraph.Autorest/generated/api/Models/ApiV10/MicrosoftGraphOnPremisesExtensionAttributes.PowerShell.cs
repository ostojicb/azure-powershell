// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.PowerShell;

    /// <summary>onPremisesExtensionAttributes</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphOnPremisesExtensionAttributesTypeConverter))]
    public partial class MicrosoftGraphOnPremisesExtensionAttributes
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphOnPremisesExtensionAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributes"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributes DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MicrosoftGraphOnPremisesExtensionAttributes(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphOnPremisesExtensionAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributes"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributes DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MicrosoftGraphOnPremisesExtensionAttributes(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphOnPremisesExtensionAttributes" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributes FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphOnPremisesExtensionAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MicrosoftGraphOnPremisesExtensionAttributes(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute1 = (string) content.GetValueForProperty("ExtensionAttribute1",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute1, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute10 = (string) content.GetValueForProperty("ExtensionAttribute10",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute10, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute11 = (string) content.GetValueForProperty("ExtensionAttribute11",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute11, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute12 = (string) content.GetValueForProperty("ExtensionAttribute12",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute12, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute13 = (string) content.GetValueForProperty("ExtensionAttribute13",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute13, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute14 = (string) content.GetValueForProperty("ExtensionAttribute14",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute14, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute15 = (string) content.GetValueForProperty("ExtensionAttribute15",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute15, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute2 = (string) content.GetValueForProperty("ExtensionAttribute2",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute2, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute3 = (string) content.GetValueForProperty("ExtensionAttribute3",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute3, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute4 = (string) content.GetValueForProperty("ExtensionAttribute4",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute4, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute5 = (string) content.GetValueForProperty("ExtensionAttribute5",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute5, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute6 = (string) content.GetValueForProperty("ExtensionAttribute6",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute6, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute7 = (string) content.GetValueForProperty("ExtensionAttribute7",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute7, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute8 = (string) content.GetValueForProperty("ExtensionAttribute8",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute8, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute9 = (string) content.GetValueForProperty("ExtensionAttribute9",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute9, global::System.Convert.ToString);
            // this type is a dictionary; copy elements from source to here.
            CopyFrom(content);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphOnPremisesExtensionAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MicrosoftGraphOnPremisesExtensionAttributes(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute1 = (string) content.GetValueForProperty("ExtensionAttribute1",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute1, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute10 = (string) content.GetValueForProperty("ExtensionAttribute10",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute10, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute11 = (string) content.GetValueForProperty("ExtensionAttribute11",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute11, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute12 = (string) content.GetValueForProperty("ExtensionAttribute12",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute12, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute13 = (string) content.GetValueForProperty("ExtensionAttribute13",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute13, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute14 = (string) content.GetValueForProperty("ExtensionAttribute14",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute14, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute15 = (string) content.GetValueForProperty("ExtensionAttribute15",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute15, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute2 = (string) content.GetValueForProperty("ExtensionAttribute2",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute2, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute3 = (string) content.GetValueForProperty("ExtensionAttribute3",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute3, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute4 = (string) content.GetValueForProperty("ExtensionAttribute4",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute4, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute5 = (string) content.GetValueForProperty("ExtensionAttribute5",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute5, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute6 = (string) content.GetValueForProperty("ExtensionAttribute6",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute6, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute7 = (string) content.GetValueForProperty("ExtensionAttribute7",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute7, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute8 = (string) content.GetValueForProperty("ExtensionAttribute8",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute8, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute9 = (string) content.GetValueForProperty("ExtensionAttribute9",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesExtensionAttributesInternal)this).ExtensionAttribute9, global::System.Convert.ToString);
            // this type is a dictionary; copy elements from source to here.
            CopyFrom(content);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// onPremisesExtensionAttributes
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphOnPremisesExtensionAttributesTypeConverter))]
    public partial interface IMicrosoftGraphOnPremisesExtensionAttributes

    {

    }
}