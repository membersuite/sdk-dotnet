using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class PaymentProcessorResponse : IMemberSuiteComponent
    {
        [DataMember]
        public bool IsPreferredProvider { get; set; }

        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string GatewayResponseCode { get; set; }

        [DataMember]
        public string GatewayResponseReasonCode { get; set; }

        [DataMember]
        public string GatewayResponseReasonText { get; set; }

        [DataMember]
        public string AuthorizationCode { get; set; }

        [DataMember]
        public string AVSResponseCode { get; set; }

        [DataMember]
        public string TransactionID { get; set; }

        [DataMember]
        public string CCVResponseCode { get; set; }

        [DataMember]
        public string Amount { get; set; }

        [DataMember]
        public string RawBankData { get; set; }

        [DataMember]
        public string PaymentID { get; set; }

        [DataMember]
        public string InvoiceID { get; set; }

        [DataMember]
        public string WorkflowExecutionID { get; set; }

        [DataMember]
        public string WorkflowRunID { get; set; }

        [DataMember]
        public string CustomerToken { get; set; }

        /// <summary>
        /// Needed for priority payment when captuing payment... 
        /// We'll need to include this ID when capturing payments..without this, the customer name don't appear in mxMerchant dashboard for transaction type of Sale
        /// </summary>
        [DataMember]
        public string CustomerID { get; set; }

        /// <summary>
        /// Required for priority paymenst capture  call
        /// </summary>
        [DataMember]
        public string TransactionReferenceNumber { get; set; }
    }
}