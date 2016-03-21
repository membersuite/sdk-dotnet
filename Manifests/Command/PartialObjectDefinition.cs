using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Manifests.Command
{
    [Serializable]
    [DataContract]
    public class PartialSearchDefinition
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Module { get; set; }

        [DataMember]
        public string Label { get; set; }

        [DataMember]
        public string ExpectedContextType { get; set; }
    }
}