using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class ValidationRule
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Expression { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public bool IsActive { get; set; }
    }
}