using System;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests;

namespace MemberSuite.SDK.Searching
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("BuiltInSearch", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
  
    [KnownType( typeof( XmlNode[] ))]
    [KnownType(typeof(string))]
    [Serializable]
    [DataContract]
    public class BuiltInSearch : MetadataBase
    {
        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public Search Search { get; set; }
    }
}
