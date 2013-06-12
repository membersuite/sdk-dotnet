using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    /// Packet of information returned to the client about a Portal
    /// </summary>
    [Serializable]
    [DataContract]
    public class PortalInformation
    {
        //Association Information
        [DataMember]
        public string AssociationName { get; set; }

        [DataMember]
        public string AssociationID { get; set; }

        [DataMember]
        public string PortalUrl { get; set; }

        [DataMember]
        public long PartitionKey { get; set; }

        [DataMember]
        public string DefaultPortalUrl { get; set; }

        
        //Portal Configuration
        [DataMember]
        public PortalSkin PortalSkin { get; set; }

        [DataMember]
        public string PortalLoginRedirect { get; set; }

        [DataMember]
        public string Css { get; set; }

        [DataMember]
        public bool HideDropShadow { get; set; }

        [DataMember]
        public string PortalGraphicHeaderUrl { get; set; }

        [DataMember]
        public string AssociationHomePageUrl { get; set; }
        
        //Login Screen
        [DataMember]
        public string PortalLoginScreenText { get; set; }

        [DataMember]
        public bool PortalDisplayBecomeMember { get; set; }

        [DataMember]
        public bool PortalDisplayMakeDonation { get; set; }

        [DataMember]
        public bool PortalDisplayCreateUserAccount { get; set; }

        //CRM
        [DataMember]
        public bool SendEmailWhenUserUpdatesInformation { get; set; }

        //Membership Directory
        [DataMember]
        public bool MembershipDirectoryEnabled { get; set; }

        [DataMember]
        public bool MembershipDirectoryForMembersOnly { get; set; }

        [DataMember]
        public List<string> MembershipDirectorySearchFields { get; set; }

        [DataMember]
        public List<string> MembershipDirectoryTabularResultsFields { get; set; }

        [DataMember]
        public List<string> MembershipDirectoryDetailsFields { get; set; }


        //Online Storefront
        [DataMember]
        public bool OnlineStorefrontEnabled { get; set; }

        [DataMember]
        public bool ShowUpcomingEventsTab { get; set; }

        //Career Center
        [DataMember]
        public short DefaultJobPostingExpiration { get; set; }

        [DataMember]
        public JobPostingAccess JobPostingAccessMode { get; set; }

        [DataMember]
        public List<string> ResumeSearchFields { get; set; }

        [DataMember]
        public List<string> ResumeTabularResultsFields { get; set; }

        [DataMember]
        public List<string> ResumeDetailsFields { get; set; }

        [DataMember]
        public List<msPortalControlPropertyOverride> ControlOverrides { get; set; }

        [DataMember]
        public string PortalLoginScreenTitle { get; set; }
    }
}
