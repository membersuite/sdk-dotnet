using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{
    public enum BillingScheduleEntryStatus
    {
        Open = 0,
        Processing =2,
        Processed = 5,
        Error = 7,
        Cancelled = 10
    }
}
