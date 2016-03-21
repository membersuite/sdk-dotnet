using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Results
{
    [Serializable]
    [DataContract]
    public class BulkAddressValidationReport
    {
        [DataMember]
        public int SuccessCount { get; set; }

        [DataMember]
        public int ErrorCount { get; set; }
    }
}