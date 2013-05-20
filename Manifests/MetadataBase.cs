using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests
{
    [Serializable]
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [DataContract]
    public class MetadataBase : IMemberSuiteComponent
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
