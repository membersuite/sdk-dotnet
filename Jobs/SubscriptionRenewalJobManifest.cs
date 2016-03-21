using System;
using MemberSuite.SDK.Searching;

namespace MemberSuite.SDK.Jobs
{
    /// <summary>
    /// </summary>
    /// <remarks></remarks>
    [Serializable]
    public class SubscriptionRenewalJobManifest
    {
        /// <summary>
        ///     Gets or sets the publication ID.
        /// </summary>
        /// <value>The publication ID.</value>
        /// <remarks></remarks>
        public string PublicationID { get; set; }

        /// <summary>
        ///     Gets or sets the subscription search to use for renewal.
        /// </summary>
        /// <value>The subscription search to use for renewal.</value>
        /// <remarks></remarks>
        public Search SubscriptionSearchToUseForRenewal { get; set; }

        /// <summary>
        ///     Gets or sets the name of the batch.
        /// </summary>
        /// <value>The name of the batch.</value>
        /// <remarks></remarks>
        public string BatchName { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [send out emails].
        /// </summary>
        /// <value><c>true</c> if [send out emails]; otherwise, <c>false</c>.</value>
        /// <remarks></remarks>
        public bool SendOutEmails { get; set; }
    }
}