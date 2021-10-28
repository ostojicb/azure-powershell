// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>onenoteSection</summary>
    public partial class MicrosoftGraphOnenoteSection :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteSection,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteSectionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModel"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModel __microsoftGraphOnenoteEntityHierarchyModel = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphOnenoteEntityHierarchyModel();

        /// <summary>identitySet</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphIdentitySet CreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).CreatedBy = value ?? null /* model class */; }

        /// <summary>
        /// The date and time when the page was created. The timestamp represents date and time information using ISO 8601 format
        /// and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntitySchemaObjectModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).CreatedDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntitySchemaObjectModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).CreatedDateTime = value ?? default(global::System.DateTime); }

        /// <summary>The name of the notebook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).DisplayName = value ?? null; }

        /// <summary>Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphOnenoteEntityHierarchyModel).Id; }

        /// <summary>Backing field for <see cref="IsDefault" /> property.</summary>
        private bool? _isDefault;

        /// <summary>Indicates whether this is the user's default section. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? IsDefault { get => this._isDefault; set => this._isDefault = value; }

        /// <summary>identitySet</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphIdentitySet LastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).LastModifiedBy = value ?? null /* model class */; }

        /// <summary>
        /// The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601
        /// format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastModifiedDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).LastModifiedDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).LastModifiedDateTime = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="Link" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSectionLinks _link;

        /// <summary>sectionLinks</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSectionLinks Link { get => (this._link = this._link ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphSectionLinks()); set => this._link = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphOnenoteEntityHierarchyModel).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphOnenoteEntityHierarchyModel).Id = value; }

        /// <summary>Backing field for <see cref="Page" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenotePage[] _page;

        /// <summary>The collection of pages in the section. Read-only. Nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenotePage[] Page { get => this._page; set => this._page = value; }

        /// <summary>Backing field for <see cref="PagesUrl" /> property.</summary>
        private string _pagesUrl;

        /// <summary>
        /// The pages endpoint where you can get details for all the pages in the section. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string PagesUrl { get => this._pagesUrl; set => this._pagesUrl = value; }

        /// <summary>Backing field for <see cref="ParentNotebook" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphNotebook _parentNotebook;

        /// <summary>notebook</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphNotebook ParentNotebook { get => (this._parentNotebook = this._parentNotebook ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphNotebook()); set => this._parentNotebook = value; }

        /// <summary>Backing field for <see cref="ParentSectionGroup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSectionGroup _parentSectionGroup;

        /// <summary>sectionGroup</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSectionGroup ParentSectionGroup { get => (this._parentSectionGroup = this._parentSectionGroup ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphSectionGroup()); set => this._parentSectionGroup = value; }

        /// <summary>The endpoint where you can get details about the page. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string Self { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityBaseModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).Self; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityBaseModelInternal)__microsoftGraphOnenoteEntityHierarchyModel).Self = value ?? null; }

        /// <summary>Creates an new <see cref="MicrosoftGraphOnenoteSection" /> instance.</summary>
        public MicrosoftGraphOnenoteSection()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__microsoftGraphOnenoteEntityHierarchyModel), __microsoftGraphOnenoteEntityHierarchyModel);
            await eventListener.AssertObjectIsValid(nameof(__microsoftGraphOnenoteEntityHierarchyModel), __microsoftGraphOnenoteEntityHierarchyModel);
        }
    }
    /// onenoteSection
    public partial interface IMicrosoftGraphOnenoteSection :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModel
    {
        /// <summary>Indicates whether this is the user's default section. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether this is the user's default section. Read-only.",
        SerializedName = @"isDefault",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefault { get; set; }
        /// <summary>sectionLinks</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"sectionLinks",
        SerializedName = @"links",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSectionLinks) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSectionLinks Link { get; set; }
        /// <summary>The collection of pages in the section. Read-only. Nullable.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of pages in the section.  Read-only. Nullable.",
        SerializedName = @"pages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenotePage) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenotePage[] Page { get; set; }
        /// <summary>
        /// The pages endpoint where you can get details for all the pages in the section. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The pages endpoint where you can get details for all the pages in the section. Read-only.",
        SerializedName = @"pagesUrl",
        PossibleTypes = new [] { typeof(string) })]
        string PagesUrl { get; set; }
        /// <summary>notebook</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"notebook",
        SerializedName = @"parentNotebook",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphNotebook) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphNotebook ParentNotebook { get; set; }
        /// <summary>sectionGroup</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"sectionGroup",
        SerializedName = @"parentSectionGroup",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSectionGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSectionGroup ParentSectionGroup { get; set; }

    }
    /// onenoteSection
    internal partial interface IMicrosoftGraphOnenoteSectionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenoteEntityHierarchyModelInternal
    {
        /// <summary>Indicates whether this is the user's default section. Read-only.</summary>
        bool? IsDefault { get; set; }
        /// <summary>sectionLinks</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSectionLinks Link { get; set; }
        /// <summary>The collection of pages in the section. Read-only. Nullable.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnenotePage[] Page { get; set; }
        /// <summary>
        /// The pages endpoint where you can get details for all the pages in the section. Read-only.
        /// </summary>
        string PagesUrl { get; set; }
        /// <summary>notebook</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphNotebook ParentNotebook { get; set; }
        /// <summary>sectionGroup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSectionGroup ParentSectionGroup { get; set; }

    }
}