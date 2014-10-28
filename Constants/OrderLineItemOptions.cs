using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Constants
{
    public static class OrderLineItemOptions
    {
        public static class Exhibits
        {
            public const string SpecialRequests = "SpecialRequests";

            public const string RegistrationWindowID = "RegistrationWindowID";
            public const string BoothPreferences = "BoothPreferences";
        }

        public static class FundraisingProducts
        {
            public const string RecognitionDetails = "RecognitionDetails";
            public const string RecognitionTypeID = "RecognitionTypeID";
            public const string RecognitionRecipient = "RecognitionRecipient";
            public const string IsAnonymous = "IsAnonymous";
            
        }

        public static class Events
        {
            public const string GroupId = "GroupID";
        }

        public static class Membership
        {
            public const string MembershipDirectoryOptOut = "MembershipDirectoryOptOut";
            public const string DoNotPassAlongUnitPriceOverride = "DoNotPassAlongUnitPriceOverride ";

            public const string PriceIncreaseCap = "PriceIncreaseCap ";
        }

        public static class Billing
        {
            public const string DoNotRenew = "DoNotRenew";
            public const string AutomaticallyPayForRenewal = "AutomaticallyPayForRenewal";
        }
    }
}
