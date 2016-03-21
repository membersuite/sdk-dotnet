using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MemberSuite.SDK.Utilities;

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
        public BatchPostingError()
        {
        }

        public BatchPostingError(string recordID, object record, string msg, params object[] args)
        {
            RecordID = recordID;
            string fMsg = StringUtil.SafeFormat(msg, args);

            RecordType = record.GetType().Name;
            ErrorMessage = fMsg;

        }

        [DataMember]
        public string RecordType { get; set; }

        [DataMember]
        public string RecordID { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1} (record identifier: {2})", RecordType, ErrorMessage, RecordID);
        }
    }
}