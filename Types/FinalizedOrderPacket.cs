using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{
    public class FinalizedOrderPacket
    {
        /// <summary>
        /// Gets or sets the finalized order.
        /// </summary>
        /// <value>The finalized order.</value>
        public MemberSuiteObject FinalizedOrder { get; set; }

        public Money SubTotal { get; set; }

        public Money ShippingCharges { get; set; }

        public Money Taxes { get; set; }

        public Money Discount { get; set; }

        public Money Total { get; set; }

        /// <summary>
        /// Gets or sets the amount due now.
        /// </summary>
        /// <value>The amount due now.</value>
        public Money AmountDueNow { get; set; }

        /// <summary>
        /// Gets or sets the future billings.
        /// </summary>
        /// <value>The future billings.</value>
        public List<FinalizedOrderPacketFutureBilling> FutureBillings { get; set; }

        public class FinalizedOrderPacketFutureBilling
        {
            public DateTime Date { get; set; }
            public Money Amount { get; set; }
        }
    }

    
}
