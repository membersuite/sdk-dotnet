using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class BatchOperation : CommandShortcut
    {
        [XmlAttribute]
        [DataMember]
        public int MinimumNumberOfSelectedRecords { get; set; }

        [XmlAttribute]
        [DataMember]
        public int MaximumNumberOfSelectedRecords { get; set; }

        public new BatchOperation Copy()
        {
            return (BatchOperation) MemberwiseClone();
        }
    }
}