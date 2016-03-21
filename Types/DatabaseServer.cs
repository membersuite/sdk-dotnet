using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("DatabaseServer", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    [DataContract]
    public class DatabaseServer : MetadataBase
    {
        [DataMember]
        public string Label { get; set; }

        [DataMember]
        public int? DisplayOrder { get; set; }

        [DataMember]
        public bool RequiresHighAvailability { get; set; }

        [DataMember]
        public bool AllowsSandboxes { get; set; }

        [DataMember]
        public string ReadOnlyName { get; set; }

        [DataMember]
        public string ServerName { get; set; }
    }
}