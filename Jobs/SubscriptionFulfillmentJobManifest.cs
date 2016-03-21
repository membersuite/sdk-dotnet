using MemberSuite.SDK.Searching;

namespace MemberSuite.SDK.Jobs
{
    /// <summary>
    /// </summary>
    /// <remarks></remarks>
    public class SubscriptionFulfillmentJobManifest
    {
        /// <summary>
        ///     Gets or sets the name of the batch.
        /// </summary>
        /// <value>The name of the batch.</value>
        /// <remarks></remarks>
        public string BatchName { get; set; }

        /// <summary>
        ///     Gets or sets the issue ID.
        /// </summary>
        /// <value>The issue ID.</value>
        /// <remarks></remarks>
        public string IssueID { get; set; }

        /// <summary>
        ///     Gets or sets the subscription search to use for fulfillment.
        /// </summary>
        /// <value>The subscription search to use for fulfillment.</value>
        /// <remarks></remarks>
        public Search SubscriptionSearchToUseForFulfillment { get; set; }

        // and, you can include members
        /// <summary>
        ///     Gets or sets the membership search to use for fulfillment.
        /// </summary>
        /// <value>The membership search to use for fulfillment.</value>
        /// <remarks></remarks>
        public Search MembershipSearchToUseForFulfillment { get; set; }
    }
}