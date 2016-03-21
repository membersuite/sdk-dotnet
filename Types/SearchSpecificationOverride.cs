using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Searching;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("SearchSpecificationContainer", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    [DataContract]
    public class SearchSpecificationOverride
    {
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
        public List<SearchSortColumn> DefaultSortFields { get; set; }

        /// <summary>
        ///     These are the default columns that the quick search will act on
        /// </summary>
        [XmlArray("DefaultQuickSearchCriteria")]
        [XmlArrayItem("CriteriaField")]
        [DataMember]
        public List<string> DefaultQuickSearchCriteria { get; set; }

        /// <summary>
        ///     These are the default output columns for quick searches
        /// </summary>
        [DataMember]
        public List<SearchOutputColumn> DefaultQuickSearchColumns { get; set; }

        [DataMember]
        public List<SearchOutputColumn> DefaultFindColumns { get; set; }
    }
}