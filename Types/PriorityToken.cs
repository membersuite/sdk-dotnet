using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class PriorityApiSettings
    {
        /// <summary>
        /// The tokenized mapping to the saved credit card.
        /// </summary>
        [DataMember]
        public bool IsPreferredConfigured { get; set; }

        /// <summary>
        /// The Priority API ID which maps directly to the Membersuite entity object such as Individual or Organization.  
        /// </summary>
        [DataMember]
        public string CustomerID { get; set; }

        /// <summary>
        /// The tokenized mapping to the saved credit card.
        /// </summary>
        [DataMember]
        public string AccessToken { get; set; }

        /// <summary>
        /// The priority payments endpoint address, will change from environment to environment...
        /// </summary>
        [DataMember]
        public string EndpointUri { get; set; }
    }
}
