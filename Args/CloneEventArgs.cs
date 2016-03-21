using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSuite.SDK.Args
{
    [Serializable]
    public class CloneEventArgs
    {
        private bool _includeConfirmationEmails;
        private bool _includeRegistrationFees;
        private bool _includeRegistrationQuestions;
        private bool _includeEventMerchandise;
        private bool _includeSupplementalInformationLinks;
        private bool _includeSessionTracks;
        private bool _includeSessionTimeslots;
        private bool _includeSponsorshipInformation;
        private bool _includeResources;
        private bool _includeRooms;

        public CloneEventArgs()
        {
        }

        public CloneEventArgs(bool includeConfirmationEmails, bool includeRegistrationFees, bool includeRegistrationQuestions, bool includeEventMerchandise, bool includeSupplementalInformationLinks, bool includeSessionTracks, bool includeSessionTimeslots, bool includeSponsorshipInformation, bool includeResources, bool includeRooms)
        {
            _includeConfirmationEmails = includeConfirmationEmails;
            _includeRegistrationFees = includeRegistrationFees;
            _includeRegistrationQuestions = includeRegistrationQuestions;
            _includeEventMerchandise = includeEventMerchandise;
            _includeSupplementalInformationLinks = includeSupplementalInformationLinks;
            _includeSessionTracks = includeSessionTracks;
            _includeSessionTimeslots = includeSessionTimeslots;
            _includeSponsorshipInformation = includeSponsorshipInformation;
            _includeResources = includeResources;
            _includeRooms = includeRooms;
        }

        public bool IncludeConfirmationEmails
        {
            get { return _includeConfirmationEmails; }
            set { _includeConfirmationEmails = value; }
        }

        public bool IncludeRegistrationFees
        {
            get { return _includeRegistrationFees; }
            set { _includeRegistrationFees = value; }
        }

        public bool IncludeRegistrationQuestions
        {
            get { return _includeRegistrationQuestions; }
            set { _includeRegistrationQuestions = value; }
        }

        public bool IncludeEventMerchandise
        {
            get { return _includeEventMerchandise; }
            set { _includeEventMerchandise = value; }
        }

        public bool IncludeSupplementalInformationLinks
        {
            get { return _includeSupplementalInformationLinks; }
            set { _includeSupplementalInformationLinks = value; }
        }

        public bool IncludeSessionTracks
        {
            get { return _includeSessionTracks; }
            set { _includeSessionTracks = value; }
        }

        public bool IncludeSessionTimeslots
        {
            get { return _includeSessionTimeslots; }
            set { _includeSessionTimeslots = value; }
        }

        public bool IncludeSponsorshipInformation
        {
            get { return _includeSponsorshipInformation; }
            set { _includeSponsorshipInformation = value; }
        }

        public bool IncludeResources
        {
            get { return _includeResources; }
            set { _includeResources = value; }
        }

        public bool IncludeRooms
        {
            get { return _includeRooms; }
            set { _includeRooms = value; }
        }

        public bool IncludeTieredRegistrationRules { get; set; }
    }

}
