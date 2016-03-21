using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests.Resource;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests.Console
{
    /// <summary>
    ///     Describes all of the elements of the console
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("ConsoleMetadata", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    [DataContract]
    public class ConsoleMetadata : MetadataBase
    {
        /// <summary>
        ///     Gets or sets the quick searches.
        /// </summary>
        /// <value>The quick searches.</value>
        [XmlArrayItem("QuickSearch")]
        [DataMember]
        public List<NameValueStringPair> QuickSearches { get; set; }

        /// <summary>
        ///     Gets or sets the tabs.
        /// </summary>
        /// <value>The tabs.</value>
        [DataMember]
        public List<Tab> Tabs { get; set; }

        [XmlArrayItem("Resource")]
        [DataMember]
        public List<StringResource> Resources { get; set; }
    }
}