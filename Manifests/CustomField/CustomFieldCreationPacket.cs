using System.Collections.Generic;
using System.Runtime.Serialization;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Manifests.CustomField
{
    /// <summary>
    /// Used to create a custom field and simultaneously update 
    /// page layout containers
    /// </summary>
    [System.Serializable]
    [DataContract]
    public class CustomFieldCreationPacket
    {
        public CustomFieldCreationPacket()
        {
            Data360PageLayouts = new List<NameValuePair>();
            DataEntryPageLayouts = new List<NameValuePair>();
            PortalPageLayouts = new List<NameValuePair>();
        }

        [DataMember]
        public MemberSuiteObject CustomFieldContainer { get; set; }

        [DataMember]
        public List<NameValuePair> DataEntryPageLayouts { get; set; }

        [DataMember]
        public List<NameValuePair> Data360PageLayouts { get; set; }

        [DataMember]
        public List<NameValuePair> PortalPageLayouts { get; set; }
    }
}
