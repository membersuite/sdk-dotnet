using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

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
