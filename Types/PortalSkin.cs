using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class PortalSkin
    {
        [DataMember]
        public string Header { get; set; }

        [DataMember]
        public string Footer { get; set; }
    }
}