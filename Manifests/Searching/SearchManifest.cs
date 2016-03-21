using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MemberSuite.SDK.Searching;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests.Searching
{
    /// <summary>
    ///     Describes everything about running a particular search - for consumption by the UI.
    ///     Takes a search specification and makes it apply to the current user/association.
    /// </summary>
    [Serializable]
    [DataContract]
    public class SearchManifest
    {
        /// <summary>
        ///     Points to the search spec
        /// </summary>
        [DataMember] public string SearchType;

        [DataMember] public string ViewCommand;

        public SearchManifest()
        {
            Fields = new List<FieldMetadata>();
            OutputFormats = new List<PickListEntry>();
        }

        [DataMember]
        public string BaseObject { get; set; }

        /// <summary>
        ///     Gets or sets the search context.
        /// </summary>
        /// <value>The search context.</value>
        [DataMember]
        public string SearchContext { get; set; }

        /// <summary>
        ///     Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        [DataMember]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Gets or sets the fields.
        /// </summary>
        /// <value>The fields.</value>
        [DataMember]
        public List<FieldMetadata> Fields { get; set; }

        /// <summary>
        ///     Gets or sets the default selected fields.
        /// </summary>
        /// <value>The default selected fields.</value>
        [DataMember]
        public List<SearchOutputColumn> DefaultSelectedFields { get; set; }

        /// <summary>
        ///     Gets or sets the default sort fieds.
        /// </summary>
        /// <value>The default sort fieds.</value>
        [DataMember]
        public List<SearchSortColumn> DefaultSortFieds { get; set; }

        [DataMember]
        public List<SearchOutputColumn> DefaultQuickSearchColumns { get; set; }

        [DataMember]
        public List<string> DefaultQuickSearchCriteria { get; set; }

        [DataMember]
        public List<SearchOutputColumn> DefaultFindColumns { get; set; }

        /// <summary>
        ///     Gets or sets the module that this search belongs to
        /// </summary>
        /// <value>The module.</value>
        [DataMember]
        public string Module { get; set; }

        /// <summary>
        ///     Gets or sets the output formats that are valid for this search
        /// </summary>
        /// <value>The output formats.</value>
        [DataMember]
        public List<PickListEntry> OutputFormats { get; set; }

        [DataMember]
        public List<BatchOperation> BatchOperations { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this search to be used for an email blast.
        /// </summary>
        /// <value><c>true</c> if [email blast eligible]; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool EmailBlastEligible { get; set; }
    }
}