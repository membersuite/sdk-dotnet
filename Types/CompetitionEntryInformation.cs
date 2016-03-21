using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    ///     Packet of information returned to the client about an Entities options for entering a competition
    /// </summary>
    [Serializable]
    [DataContract]
    public class CompetitionEntryInformation
    {
        [DataMember]
        public int NumberOfNonDraftEntries { get; set; }

        [DataMember]
        public int NumberOfDraftEntries { get; set; }

        [DataMember]
        public bool CanEnter { get; set; }

        [DataMember]
        public List<CompetitionEntryFeeProductInfo> CompetitionEntryFees { get; set; }

        [DataMember]
        public string SubmittedStatusId { get; set; }

        [DataMember]
        public string PendingPaymentStatusId { get; set; }

        [DataMember]
        public string DraftStatusId { get; set; }
    }
}