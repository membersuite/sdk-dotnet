using System.Collections.Generic;

namespace MemberSuite.SDK.Types
{
    public class MembershipCancellationOptions
    {
        public bool DoNotCancelMembership { get; set; }

        public List<CancellationFeeManifest> CancellationFees { get; set; }

        public LinkedCancellationBehavior CancelChapters { get; set; }

        /// <summary>
        /// Gets or sets the linked registrations to include/exclude
        ///  based on the CancelLinkedRegistrations behavior.
        /// </summary>
        /// <value>The linked registrations.</value>
        public List<string> Chapters { get; set; }

        public LinkedCancellationBehavior CancelSections { get; set; }

        /// <summary>
        /// Gets or sets the linked registrations to include/exclude
        ///  based on the CancelLinkedRegistrations behavior.
        /// </summary>
        /// <value>The linked registrations.</value>
        public List<string> Sections { get; set; }

        public LinkedCancellationBehavior CancelAddOns { get; set; }

        /// <summary>
        /// Gets or sets the linked registrations to include/exclude
        ///  based on the CancelLinkedRegistrations behavior.
        /// </summary>
        /// <value>The linked registrations.</value>
        public List<string> AddOns { get; set; }

        /// <summary>
        /// Gets or sets the refund instructions.
        /// </summary>
        /// <value>The refund instructions.</value>
        public OrderCancellationRefundInstructions RefundInstructions { get; set; }

        
    }
}
