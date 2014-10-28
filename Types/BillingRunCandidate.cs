using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{
    public class BillingRunCandidate
    {
        public string BillingRun_ID { get; set; }
        public BillingRunCandidateType Action { get; set; }
        public string Owner_ID { get; set; }
        public string Owner_Name { get; set; }
        public string Owner_Type { get; set; }
        public string Candidate_ID { get; set; }
        public string Candidate_Name { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }

        public DateTime Candidate_ExpirationDate { get; set; }
        public string Product_ID { get; set; }
    }
}
