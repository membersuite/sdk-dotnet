using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MemberSuite.SDK.Searching;

namespace MemberSuite.SDK.Jobs
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public class MassAssignEntitlementsJobManifest
    {
        /// <summary>
        /// Gets or sets the type of the entitlement.
        /// </summary>
        /// <value>The type of the entitlement.</value>
        /// <remarks></remarks>
        public string EntitlementType { get; set; }
        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        /// <value>The context.</value>
        /// <remarks></remarks>
        public string Context { get; set; }
        /// <summary>
        /// Gets or sets the available from.
        /// </summary>
        /// <value>The available from.</value>
        /// <remarks></remarks>
        public DateTime? AvailableFrom { get; set; }
        /// <summary>
        /// Gets or sets the available until.
        /// </summary>
        /// <value>The available until.</value>
        /// <remarks></remarks>
        public DateTime? AvailableUntil { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        /// <remarks></remarks>
        public decimal Quantity { get; set; }
        
    }
}
