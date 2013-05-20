using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

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
