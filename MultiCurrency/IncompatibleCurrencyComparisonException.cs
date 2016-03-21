using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSuite.SDK.MultiCurrency
{
    public class IncompatibleCurrencyComparisonException : Exception 
    {
        public IncompatibleCurrencyComparisonException() : base ("You are attempting to compare two incompatible currencies.")
        {
        }
    }
}
