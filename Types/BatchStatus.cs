using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{
    public enum BatchStatus
    {

        Open = 0,
        Closed = 10,
        Verified = 20,
        Posted = 30,
        Error = 35,
        Archived = 40

    }

    public enum BatchType
    {
        Regular = 0,
        DeferredRevenue = 5,
        COGS = 10
    }
}
