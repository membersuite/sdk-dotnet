using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class ProductInfo
    {
        public ProductInfo()
        {
            IsEligible = true;
        }

        [DataMember]
        public int? DisplayOrder { get; set; }

        [DataMember]
        public string ProductType { get; set; }

        [DataMember]
        public string ProductID { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public string Image { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public string DisplayPriceAs { get; set; }

        [DataMember]
        public bool IsEligible { get; set; }

        [DataMember]
        public bool IsSoldOut { get; set; }

        [DataMember]
        public bool SellOnline { get; set; }

        [DataMember]
        public bool IsNew { get; set; }
    }

    [Serializable]
    [DataContract]
    public class MembershipProductInfo : ProductInfo
    {
        /// <summary>
        ///     Gets or sets the type of the membership.
        /// </summary>
        /// <value>The type of the membership.</value>
        /// <remarks>For membership products only, this is set - otherwise, ignored</remarks>
        [DataMember]
        public string MembershipType { get; set; }
    }

    [Serializable]
    [DataContract]
    public class EventRegistrationProductInfo : ProductInfo
    {
        [DataMember]
        public bool IsGuestRegistration { get; set; }
    }

    [Serializable]
    public class CompetitionEntryFeeProductInfo : ProductInfo
    {
    }
}