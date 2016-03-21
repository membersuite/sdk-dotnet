using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSuite.SDK.MultiCurrency
{
    public class InvalidCurrencyCodeException : Exception
    {
        public InvalidCurrencyCodeException(string code) : base(
            string.Format("'{0}' is not a valid currency code.", code ) )
        {
        }
    }
}
