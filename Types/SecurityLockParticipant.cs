using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [DataContract]
    public class SecurityLockParticipant
    {
        [DataMember]
        public string RoleID { get; set; }

        [DataMember]
        public SecurityLockAccessLevel AccessLevel { get; set; }
    }
}
