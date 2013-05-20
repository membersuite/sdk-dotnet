using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

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
