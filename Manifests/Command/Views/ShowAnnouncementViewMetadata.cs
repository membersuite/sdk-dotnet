using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Manifests.Command.Views
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("SearchViewMetadata", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    [DataContract]
    public class ShowAnnouncementViewMetadata
    {
        [DataMember]
        public string Announcement { get; set; }

        [DataMember]
        public string AnnouncementID { get; set; }
    }
}