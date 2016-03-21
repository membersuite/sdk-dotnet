using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class BatchReadinessReport
    {
        public BatchReadinessReport()
        {
            IncompleteProducts = new List<BatchReadinessReportIncompleteProduct>();
            MissingDueToDueFromEntries = new List<BatchReadinessReportMissingDueToDueFrom>();
            IncompleteBusinessUnits = new List<BatchReadinessReportIncompleteBusinessUnit>();
        }

        [DataMember]
        public bool CanBePosted { get; set; }

        /// <summary>
        ///     Gets or sets the missing revenue L Accouns
        /// </summary>
        /// <value>The missing revenue G ls.</value>
        /// <remarks>These are a list of product IDs with missing</remarks>
        [DataMember]
        public List<BatchReadinessReportIncompleteProduct> IncompleteProducts { get; set; }

        /// <summary>
        ///     Gets or sets the missing due to due from entries.
        /// </summary>
        /// <value>The missing due to due from entries.</value>
        [DataMember]
        public List<BatchReadinessReportMissingDueToDueFrom> MissingDueToDueFromEntries { get; set; }

        /// <summary>
        ///     Gets or sets the incomplete business units.
        /// </summary>
        /// <value>The incomplete business units.</value>
        [DataMember]
        public List<BatchReadinessReportIncompleteBusinessUnit> IncompleteBusinessUnits { get; set; }

        /// <summary>
        ///     Gets or sets the pro forma invoice count.
        /// </summary>
        /// <value>The pro forma invoice count.</value>
        [DataMember]
        public long ProFormaInvoiceCount { get; set; }
    }

    public class BatchReadinessReportIncompleteProduct
    {
        public string ProductID { get; set; }
        public string ProductFullName { get; set; }
        public string MissingAccountType { get; set; }
    }

    public class BatchReadinessReportMisplacedInvoice
    {
        public string PaymentID { get; set; }
        public string PaymentName { get; set; }
        public string InvoiceID { get; set; }
        public string InvoiceName { get; set; }
    }

    /// <summary>
    ///     Represents missing (but necessary) due to/due from entries
    /// </summary>
    public class BatchReadinessReportMissingDueToDueFrom
    {
        /// <summary>
        ///     Gets or sets from business unit.
        /// </summary>
        /// <value>From business unit.</value>
        public string FromBusinessUnitID { get; set; }

        /// <summary>
        ///     Gets or sets the name of from business unit.
        /// </summary>
        /// <value>The name of from business unit.</value>
        public string FromBusinessUnitName { get; set; }

        /// <summary>
        ///     Gets or sets to business unit.
        /// </summary>
        /// <value>To business unit.</value>
        public string ToBusinessUnit { get; set; }

        /// <summary>
        ///     Gets or sets the name of to business unit.
        /// </summary>
        /// <value>The name of to business unit.</value>
        public string ToBusinessUnitName { get; set; }
    }

    public class BatchReadinessReportIncompleteBusinessUnit
    {
        /// <summary>
        ///     Gets or sets the business unit ID.
        /// </summary>
        /// <value>The business unit ID.</value>
        public string BusinessUnitID { get; set; }

        /// <summary>
        ///     Gets or sets the name of the business unit.
        /// </summary>
        /// <value>The name of the business unit.</value>
        public string BusinessUnitName { get; set; }

        public string GLAccountType { get; set; }
    }
}