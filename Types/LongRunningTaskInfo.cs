using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class LongRunningTaskInfo
    {
        [DataMember]
        public string WorkflowID { get; set; }

        [DataMember]
        public string RunID { get; set; }
    }

    [Serializable]
    [DataContract]
    public class LongRunningTaskStatusInfo
    {
        public LongRunningTaskStatusInfo()
        {
        }

        public LongRunningTaskStatusInfo(LongRunningTaskInfo info)
        {
            if (info == null) throw new ArgumentNullException("info");
            WorkflowID = info.WorkflowID;
            RunID = info.RunID;
        }

        [DataMember]
        public string WorkflowID { get; set; }

        [DataMember]
        public string RunID { get; set; }

        [DataMember]
        public LongRunningTaskStatus Status { get; set; }

        [DataMember]
        public string AdditionalInfo { get; set; }


    }

    public enum LongRunningTaskStatus
    {
        Running,
        Completed,
        Canceled,
        Failed,
        Unknown
        
    }
}
