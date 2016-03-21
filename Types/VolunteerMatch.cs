using System;

namespace MemberSuite.SDK.Types
{
    public class VolunteerMatch
    {
        public string JobID { get; set; }
        public string JobName { get; set; }
        public string JobOccurrenceID { get; set; }
        public string JobOccurrenceName { get; set; }
        public DateTime? JobOccurrenceStart { get; set; }
        public DateTime? JobOccurrenceEnd { get; set; }
        public decimal MatchPercentage { get; set; }
        public string VolunteerID { get; set; }
        public string IndividualID { get; set; }
        public string IndividualFirstName { get; set; }
        public string IndividualLastName { get; set; }
    }
}