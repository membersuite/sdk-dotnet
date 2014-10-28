using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class PreProcessedOrderPacket
    {
        /// <summary>
        /// Gets or sets the finalized order.
        /// </summary>
        /// <value>The finalized order.</value>
        [DataMember]
        public MemberSuiteObject FinalizedOrder { get; set; }

        [DataMember]
        public decimal SubTotal { get; set; }

        [DataMember]
        public decimal ShippingCharges { get; set; }

        [DataMember]
        public decimal Taxes { get; set; }

        [DataMember]
        public decimal Discount { get; set; }

        [DataMember]
        public decimal Total { get; set; }

        [DataMember]
        public bool ShippingMethodRequired { get; set; }

        [DataMember]
        public bool ShippingCarrierError { get; set; }

        [DataMember]
        public string ShippingCarrierErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [customer can pay later].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [customer can pay later]; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool CustomerCanPayLater { get; set; }

        /// <summary>
        /// Gets or sets the amount due now.
        /// </summary>
        /// <value>The amount due now.</value>
        [DataMember]
        public decimal AmountDueNow { get; set; }

        [DataMember]
        public List<string> ProductTypes { get; set; }

        [DataMember]
        public List<string> ProductNames { get; set; }


        /// <summary>
        /// Gets or sets the product demographics for the products in this order
        /// </summary>
        /// <value>The product demographics.</value>
        [DataMember]
        public List<List<FieldMetadata>> ProductDemographics { get; set; }

        /// <summary>
        /// Gets or sets the future billings.
        /// </summary>
        /// <value>The future billings.</value>
        [DataMember]
        public List<PreProcessedOrderPacketFutureBilling> FutureBillings { get; set; }

        [DataMember]
        public List<ProductInfo> CrossSellCandidates { get; set; }

        [DataContract]
        [Serializable]
        public class PreProcessedOrderPacketFutureBilling
        {
            [DataMember]
            public DateTime Date { get; set; }

            [DataMember]
            public decimal Amount { get; set; }
        }
    }

    
}
