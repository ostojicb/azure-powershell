// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>
    /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity
    /// types.
    /// </summary>
    public partial class MicrosoftGraphDevice
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDevice.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDevice.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDevice FromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json ? new MicrosoftGraphDevice(json, new global::System.Collections.Generic.HashSet<string>(){ @"id",@"deletedDateTime",@"displayName",@"@odata.type",@"@odata.id",@"accountEnabled",@"alternativeSecurityIds",@"approximateLastSignInDateTime",@"complianceExpirationDateTime",@"deviceId",@"deviceMetadata",@"deviceVersion",@"isCompliant",@"isManaged",@"mdmAppId",@"onPremisesLastSyncDateTime",@"onPremisesSyncEnabled",@"operatingSystem",@"operatingSystemVersion",@"physicalIds",@"profileType",@"systemLabels",@"trustType",@"memberOf",@"registeredOwners",@"registeredUsers",@"transitiveMemberOf",@"extensions" }) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphDevice" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject instance to deserialize from.</param>
        /// <param name="exclusions"></param>
        internal MicrosoftGraphDevice(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json, global::System.Collections.Generic.HashSet<string> exclusions = null)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.FromJson( json, ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>)this).AdditionalProperties, Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.DeserializeDictionary(()=>new global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object>()),exclusions );
            __microsoftGraphDirectoryObject = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphDirectoryObject(json);
            {_accountEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonBoolean>("accountEnabled"), out var __jsonAccountEnabled) ? (bool?)__jsonAccountEnabled : AccountEnabled;}
            {_alternativeSecurityId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray>("alternativeSecurityIds"), out var __jsonAlternativeSecurityIds) ? If( __jsonAlternativeSecurityIds as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAlternativeSecurityId[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAlternativeSecurityId) (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphAlternativeSecurityId.FromJson(__u) )) ))() : null : AlternativeSecurityId;}
            {_approximateLastSignInDateTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("approximateLastSignInDateTime"), out var __jsonApproximateLastSignInDateTime) ? global::System.DateTime.TryParse((string)__jsonApproximateLastSignInDateTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonApproximateLastSignInDateTimeValue) ? __jsonApproximateLastSignInDateTimeValue : ApproximateLastSignInDateTime : ApproximateLastSignInDateTime;}
            {_complianceExpirationDateTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("complianceExpirationDateTime"), out var __jsonComplianceExpirationDateTime) ? global::System.DateTime.TryParse((string)__jsonComplianceExpirationDateTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonComplianceExpirationDateTimeValue) ? __jsonComplianceExpirationDateTimeValue : ComplianceExpirationDateTime : ComplianceExpirationDateTime;}
            {_deviceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("deviceId"), out var __jsonDeviceId) ? (string)__jsonDeviceId : (string)DeviceId;}
            {_deviceMetadata = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("deviceMetadata"), out var __jsonDeviceMetadata) ? (string)__jsonDeviceMetadata : (string)DeviceMetadata;}
            {_deviceVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNumber>("deviceVersion"), out var __jsonDeviceVersion) ? (int?)__jsonDeviceVersion : DeviceVersion;}
            {_isCompliant = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonBoolean>("isCompliant"), out var __jsonIsCompliant) ? (bool?)__jsonIsCompliant : IsCompliant;}
            {_isManaged = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonBoolean>("isManaged"), out var __jsonIsManaged) ? (bool?)__jsonIsManaged : IsManaged;}
            {_mdmAppId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("mdmAppId"), out var __jsonMdmAppId) ? (string)__jsonMdmAppId : (string)MdmAppId;}
            {_onPremisesLastSyncDateTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("onPremisesLastSyncDateTime"), out var __jsonOnPremisesLastSyncDateTime) ? global::System.DateTime.TryParse((string)__jsonOnPremisesLastSyncDateTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonOnPremisesLastSyncDateTimeValue) ? __jsonOnPremisesLastSyncDateTimeValue : OnPremisesLastSyncDateTime : OnPremisesLastSyncDateTime;}
            {_onPremisesSyncEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonBoolean>("onPremisesSyncEnabled"), out var __jsonOnPremisesSyncEnabled) ? (bool?)__jsonOnPremisesSyncEnabled : OnPremisesSyncEnabled;}
            {_operatingSystem = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("operatingSystem"), out var __jsonOperatingSystem) ? (string)__jsonOperatingSystem : (string)OperatingSystem;}
            {_operatingSystemVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("operatingSystemVersion"), out var __jsonOperatingSystemVersion) ? (string)__jsonOperatingSystemVersion : (string)OperatingSystemVersion;}
            {_physicalId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray>("physicalIds"), out var __jsonPhysicalIds) ? If( __jsonPhysicalIds as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : PhysicalId;}
            {_profileType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("profileType"), out var __jsonProfileType) ? (string)__jsonProfileType : (string)ProfileType;}
            {_systemLabel = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray>("systemLabels"), out var __jsonSystemLabels) ? If( __jsonSystemLabels as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : SystemLabel;}
            {_trustType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("trustType"), out var __jsonTrustType) ? (string)__jsonTrustType : (string)TrustType;}
            {_memberOf = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray>("memberOf"), out var __jsonMemberOf) ? If( __jsonMemberOf as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject) (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphDirectoryObject.FromJson(__f) )) ))() : null : MemberOf;}
            {_registeredOwner = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray>("registeredOwners"), out var __jsonRegisteredOwners) ? If( __jsonRegisteredOwners as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject) (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphDirectoryObject.FromJson(__a) )) ))() : null : RegisteredOwner;}
            {_registeredUser = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray>("registeredUsers"), out var __jsonRegisteredUsers) ? If( __jsonRegisteredUsers as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___w, (___v)=>(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject) (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphDirectoryObject.FromJson(___v) )) ))() : null : RegisteredUser;}
            {_transitiveMemberOf = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray>("transitiveMemberOf"), out var __jsonTransitiveMemberOf) ? If( __jsonTransitiveMemberOf as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray, out var ___r) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___r, (___q)=>(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject) (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphDirectoryObject.FromJson(___q) )) ))() : null : TransitiveMemberOf;}
            {_extension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray>("extensions"), out var __jsonExtensions) ? If( __jsonExtensions as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray, out var ___m) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphExtension[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(___m, (___l)=>(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphExtension) (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphExtension.FromJson(___l) )) ))() : null : Extension;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphDevice" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphDevice" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.ToJson( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>)this).AdditionalProperties, container);
            __microsoftGraphDirectoryObject?.ToJson(container, serializationMode);
            AddIf( null != this._accountEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonBoolean((bool)this._accountEnabled) : null, "accountEnabled" ,container.Add );
            if (null != this._alternativeSecurityId)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.XNodeArray();
                foreach( var __x in this._alternativeSecurityId )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("alternativeSecurityIds",__w);
            }
            AddIf( null != this._approximateLastSignInDateTime ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._approximateLastSignInDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "approximateLastSignInDateTime" ,container.Add );
            AddIf( null != this._complianceExpirationDateTime ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._complianceExpirationDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "complianceExpirationDateTime" ,container.Add );
            AddIf( null != (((object)this._deviceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._deviceId.ToString()) : null, "deviceId" ,container.Add );
            AddIf( null != (((object)this._deviceMetadata)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._deviceMetadata.ToString()) : null, "deviceMetadata" ,container.Add );
            AddIf( null != this._deviceVersion ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNumber((int)this._deviceVersion) : null, "deviceVersion" ,container.Add );
            AddIf( null != this._isCompliant ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonBoolean((bool)this._isCompliant) : null, "isCompliant" ,container.Add );
            AddIf( null != this._isManaged ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonBoolean((bool)this._isManaged) : null, "isManaged" ,container.Add );
            AddIf( null != (((object)this._mdmAppId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._mdmAppId.ToString()) : null, "mdmAppId" ,container.Add );
            AddIf( null != this._onPremisesLastSyncDateTime ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._onPremisesLastSyncDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "onPremisesLastSyncDateTime" ,container.Add );
            AddIf( null != this._onPremisesSyncEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonBoolean((bool)this._onPremisesSyncEnabled) : null, "onPremisesSyncEnabled" ,container.Add );
            AddIf( null != (((object)this._operatingSystem)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._operatingSystem.ToString()) : null, "operatingSystem" ,container.Add );
            AddIf( null != (((object)this._operatingSystemVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._operatingSystemVersion.ToString()) : null, "operatingSystemVersion" ,container.Add );
            if (null != this._physicalId)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.XNodeArray();
                foreach( var __s in this._physicalId )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("physicalIds",__r);
            }
            AddIf( null != (((object)this._profileType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._profileType.ToString()) : null, "profileType" ,container.Add );
            if (null != this._systemLabel)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.XNodeArray();
                foreach( var __n in this._systemLabel )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("systemLabels",__m);
            }
            AddIf( null != (((object)this._trustType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._trustType.ToString()) : null, "trustType" ,container.Add );
            if (null != this._memberOf)
            {
                var __h = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.XNodeArray();
                foreach( var __i in this._memberOf )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("memberOf",__h);
            }
            if (null != this._registeredOwner)
            {
                var __c = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.XNodeArray();
                foreach( var __d in this._registeredOwner )
                {
                    AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                }
                container.Add("registeredOwners",__c);
            }
            if (null != this._registeredUser)
            {
                var ___x = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.XNodeArray();
                foreach( var ___y in this._registeredUser )
                {
                    AddIf(___y?.ToJson(null, serializationMode) ,___x.Add);
                }
                container.Add("registeredUsers",___x);
            }
            if (null != this._transitiveMemberOf)
            {
                var ___s = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.XNodeArray();
                foreach( var ___t in this._transitiveMemberOf )
                {
                    AddIf(___t?.ToJson(null, serializationMode) ,___s.Add);
                }
                container.Add("transitiveMemberOf",___s);
            }
            if (null != this._extension)
            {
                var ___n = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.XNodeArray();
                foreach( var ___o in this._extension )
                {
                    AddIf(___o?.ToJson(null, serializationMode) ,___n.Add);
                }
                container.Add("extensions",___n);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}