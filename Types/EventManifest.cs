using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    /// A manifest of everything needed to generate a registration form for an event
    /// </summary>
    [Serializable]
    [DataContract]
    public class EventManifest
    {
        [DataMember]
        public List<EventRegistrationProductInfo> GuestRegistrationFees { get; set; }

        [DataMember]
        public List<EventManifestSession> Sessions { get; set; }

        [DataMember]
        public List<ProductInfo> Merchandise { get; set; }
        
    }

    [Serializable]
    [DataContract]
    public class EventManifestSession
    {
        [DataMember]
        public string SessionID { get; set; }

        [DataMember]
        public string SessionName { get; set; }

        [DataMember]
        public string SessionDescription { get; set; }

        [DataMember]
        public string TimeSlotID { get; set; }

        [DataMember]
        public string TimeSlotName { get; set; }

        [DataMember]
        public bool IsSoldOut { get; set; }
        
        /// <summary>
        /// Gets or sets the fee to use for registration.
        /// </summary>
        /// <value>The fee to use for registration.</value>
        /// <remarks>If this is set, then you should use THIS fee when a person registered. If there
        /// are multiple available fees, then this value will be null and you should allow the user to
        /// select.</remarks>
        [DataMember]
        public string DefaultFee { get; set; }

        [DataMember]
        public EventRegistrationMode RegistrationMode { get; set; }

        /// <summary>
        /// Gets or sets the fees.
        /// </summary>
        /// <value>The fees.</value>
        /// This is a list of all fees available for this session
        [DataMember]
        public List<EventRegistrationProductInfo> Fees { get; set; }

        [DataMember]
        public bool Ineligible { get; set; }

        [DataMember]
        public string Tracks { get; set; }
    }
}
