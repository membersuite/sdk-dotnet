using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Manifests.Resource
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("Resource", Namespace = "http://membersuite.com/schemas/", 
        IsNullable = false)]
    [System.Serializable]
    [DataContract]
    public class StringResource  
    {
        [XmlAttribute]
        [DataMember]
        public string Name { get; set; }

        [XmlText]
        [DataMember]
        public string Value { get; set; }
    }
}