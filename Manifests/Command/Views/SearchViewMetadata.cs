using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Manifests.Command.Views
{
    /// <summary>
    ///     Holds information about all of the widgets on a Search.
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("SearchViewMetadata", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    [DataContract]
    public class SearchViewMetadata : MetadataBase
    {
        [DataMember]
        public bool HideOutputColumns { get; set; }

        [DataMember]
        public bool HideSort { get; set; }

        [DataMember]
        public bool HideOutputFormat { get; set; }
    }
}