using System.Collections.Generic;

namespace MemberSuite.SDK.Types
{
    public class RegistrationCancellationOptions
    {
        public RegistrationCancellationOptions()
        {
            LinkedRegistrations = new List<string>();
            Merchandise = new List<string>();
        }

        public bool DoNotCancelMainRegistration { get; set; }

        public List<CancellationFeeManifest> CancellationFees { get; set; }

        public LinkedCancellationBehavior CancelLinkedRegistrations { get; set; }
        
        /// <summary>
        /// Gets or sets the linked registrations to include/exclude
        ///  based on the CancelLinkedRegistrations behavior.
        /// </summary>
        /// <value>The linked registrations.</value>
        public List<string> LinkedRegistrations { get; set; }

        public LinkedCancellationBehavior CancelMerchandise { get; set; }
        
        /// <summary>
        /// Gets or sets the linked merchandise to include/exclude
        ///  based on the Cancel Merchandise behavior.
        /// </summary>
        /// <value>The linked registrations.</value>
        public List<string> Merchandise { get; set; }

        public LinkedCancellationBehavior CancelSessions { get; set; }

        public List<string> SessionRegistrations { get; set; }

        /// <summary>
        /// Gets or sets the refund instructions.
        /// </summary>
        /// <value>The refund instructions.</value>
        public OrderCancellationRefundInstructions RefundInstructions { get; set; }

    }
}