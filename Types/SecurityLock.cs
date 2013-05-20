using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{

    /// <summary>
    /// Represents a lock on a particular record, indicating which people have access
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [DataContract]
    public class SecurityLock : IMemberSuiteComponent
    {
        public SecurityLock()
        {
            Participants = new List<SecurityLockParticipant>();
        }

        [DataMember]
        public List<SecurityLockParticipant> Participants { get; set; }
    }
}
