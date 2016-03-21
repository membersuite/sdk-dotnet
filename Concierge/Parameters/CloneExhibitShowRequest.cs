using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Concierge.Parameters
{
    public class CloneExhibitShowRequest : ConciergeRequest
    {
        public string SourceExhibitShowID { get; set; }
        public MemberSuiteObject DestinationShow { get; set; }
        public CloneExhibitShowOptions Options { get; set; }
    }

    public class CloneExhibitShowOptions
    {
        public CloneExhibitShowOptions()
        {
            CloneBoothsAndFees = true;
            CloneMerchandise = true;
            CloneContactRestrictions = true;
            CloneRegistrationWindows = true;
            CloneSponsorshipsAndFees = true;
        }

        public bool CloneBoothsAndFees { get; set; }
        public bool CloneMerchandise { get; set; }
        public bool CloneContactRestrictions { get; set; }
        public bool CloneRegistrationWindows { get; set; }
        public bool CloneSponsorshipsAndFees { get; set; }
    }
}