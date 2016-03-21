using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class PriorityApiSettings
    {
        /// <summary>
        ///     The tokenized mapping to the saved credit card.
        /// </summary>
        [DataMember]
        public bool IsPreferredConfigured { get; set; }

        /// <summary>
        ///     The Priority API ID which maps directly to the Membersuite entity object such as Individual or Organization.
        /// </summary>
        [DataMember]
        public string CustomerID { get; set; }

        /// <summary>
        ///     The tokenized mapping to the saved credit card.
        /// </summary>
        [DataMember]
        public string AccessToken { get; set; }

        /// <summary>
        ///     The priority payments endpoint address, will change from environment to environment...
        /// </summary>
        [DataMember]
        public string EndpointUri { get; set; }

        /// <summary>
        /// The destination URI where our JS logic should log information about the transaction to.
        /// </summary>
        [DataMember]
        public string LoggingUri { get; set; }

        /// <summary>
        /// The destination port where our JS logic should log information about the transaction to.
        /// </summary>
        [DataMember]
        public string LoggingPort { get; set; }


        /// <summary>
        /// Customer Type..priority payment API requires a customer type to be sent.. currently they support two types (Person/Company), which matches our Individual/Organization
        /// </summary>
        [DataMember]
        public string CustomerType { get; set; }
        /// <summary>
        /// Customer's First Name
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer's Last Name
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Customer's Email Address
        /// </summary>
        [DataMember]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Customer's Name (this is especially needed for organizations
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Customer's preferred Address Name
        /// </summary>
        [DataMember]
        public string AddressName { get; set; }

        /// <summary>
        /// Customer's  preferred Address  Address1
        /// </summary>
        [DataMember]
        public string Address1 { get; set; }

        /// <summary>
        /// Customer's  preferred Address  Address2
        /// </summary>
        [DataMember]
        public string Address2 { get; set; }

        /// <summary>
        /// Customer's preferred Address City
        /// </summary>
        [DataMember]
        public string City { get; set; }

        /// <summary>
        /// Customer's  preferred Address State
        /// </summary>
        [DataMember]
        public string State { get; set; }

        /// <summary>
        /// Customer's  preferred Address Zip
        /// </summary>
        [DataMember]
        public string Zip { get; set; }


    }
}
