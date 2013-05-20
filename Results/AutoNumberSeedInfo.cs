using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Results
{
    [Serializable]
    [DataContract]
    public class AutoNumberSeedInfo
    {
        [DataMember]
        public string ObjectName { get; set; }

        [DataMember]
        public long NextValue { get; set; }

        [DataMember]
        public long? HighestValueInDatabase { get; set; }
    }
}
