using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    /// Represents a summary for a specific entity's entitlements for a given type/context.
    /// </summary>
    public class EntitlementReport
    {
        public string Owner {get;set;}
        public string EntitlementType { get; set; }
        public string Context { get; set; }
        
        public bool IsEntitled { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? AvailableUntil { get; set; }

       
    }
}
