using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberSuite.SDK.MultiCurrency
{
    public static class SumExtensionsForCurrency
    {
        public static Currency Sum(this IEnumerable<Currency> source)
        {
            return source.Aggregate((x, y) => x + y);
        }

        public static Currency Sum<T>(this IEnumerable<T> source, Func<T, Currency> selector)
        {
            return source.Select(selector).Aggregate((x, y) => x + y);
        }
    }
}
