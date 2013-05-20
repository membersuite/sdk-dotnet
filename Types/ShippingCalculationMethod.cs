using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{
    public enum ShippingCalculationMethod
    {
        FreeShipping = 0,
        ByOrderWeight = 10,
        ByOrderValue = 20,
        ByOrderQuantity = 30
    }
}
