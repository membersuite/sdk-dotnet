using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Manifests.Command
{
    [Serializable]
    [DataContract]
    public class PartialObjectDefinition
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Module { get; set; }

        [DataMember]
        public string Label { get; set; }
    }
}