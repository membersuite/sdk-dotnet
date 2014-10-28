using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests
{
    [Serializable]
    [DataContract]
    public class OrderPayload
    {
        [DataMember]
        public List<MemberSuiteObject> ObjectsToSave { get; set; }

        [DataMember]
        public List<OrderPayloadEntitlementAdjustments> EntitlementAdjustments { get; set; }

        public override string ToString()
        {
            return string.Format("{0} objects to save, {1} entitlement adjustments",
                ObjectsToSave != null ? ObjectsToSave.Count : 0,
                EntitlementAdjustments != null ? EntitlementAdjustments.Count : 0);
            
        }
    }

    [Serializable]
    [DataContract]
    public class OrderPayloadEntitlementAdjustments
    {

        [DataMember]
        public string EntityID { get; set; }

        [DataMember]
        public string EntitlementType { get; set; }
        [DataMember]
        public string Context { get; set; }
        [DataMember]
        public decimal AmountToAdjust { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
