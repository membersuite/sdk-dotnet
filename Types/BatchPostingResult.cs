using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class BatchPostingResult
    {
        [DataMember]
        public string BatchID { get; set; }

        [DataMember]
        public string BatchName { get; set; }

        [DataMember]
        public bool Successful { get; set; }

        [DataMember]
        public List<BatchPostingError> Errors { get; set; }
    }

    [Serializable]
    [DataContract]
    public class BatchPostingError
    {
        [DataMember]
        public string RecordType { get; set; }

        [DataMember]
        public string RecordID { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }
    }
}
