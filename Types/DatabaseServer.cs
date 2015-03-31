using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
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
    }
}
