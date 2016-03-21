using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberSuite.SDK.Types;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.MultiCurrency
{
    public static class CurrencyManager
    {
        static CurrencyManager()
        {
            initializeCurrenciesFromEmbeddedResource();
        }

        private static Dictionary<string, world_currency> currency_dic;


        private static void initializeCurrenciesFromEmbeddedResource()
        {

            // we're going to get the embedded xml file and load up all of the world currencies
            // we'll keep 'em in a static dictionary, below
            currency_dic = new Dictionary<string, world_currency>();

            // get the resource
            var pathToResource = typeof (CurrencyManager).Namespace + ".WorldCurrencies.xml";
            var currencyMap = EmbeddedResource.LoadAsXmlLinq(pathToResource);

            if (currencyMap == null)
                throw new Exception(string.Format("Unable to locate resource {0} - cannot manage currencies.",
                    pathToResource) );

            // now, we'll pull all of the currencies
            var currencies = from c in currencyMap.Descendants("currency")
                select c;

            // for each item in the currency, we add it to a dictionary
            foreach (var c in currencies)
            {
                // pull the item
                string code = c.Attribute("code").Value.ToUpper();
                string symbol = _convertUnicodeValuesToString(c.Attribute("unicode-decimal").Value);
                string name = c.Value;

                // create it
                var wc = new world_currency(code, symbol, name);

                if (currency_dic.ContainsKey(code))
                    throw new Exception("Dictionary already has " + code);
                currency_dic.Add(code, wc); // add it to the dictionary
            }

        }

        /// <summary>
        /// Converts a set of comma separate unicode values to a tring
        /// </summary>
        /// <param name="sequenceOfValues">The sequence of values.</param>
        /// <returns>System.String.</returns>
        private static string _convertUnicodeValuesToString(string sequenceOfValues)
        {
            // if you look at our XML file, you see we specify the currency symbol as a concatenated
            // value of unicode values
            // we need to convert this to a string a store it
            var strValues = sequenceOfValues.Split(',');
            string symbol = "";

            foreach (var v in strValues)
            {
                if (string.IsNullOrWhiteSpace(v))
                    continue;   // happens sometimes, like for the Rupee
                int unicodeValue = int.Parse(v);
                symbol += (char)unicodeValue;
            }

            return symbol;
        }

        /// <summary>
        /// Determines whether the specified code is a valid currency code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns><c>true</c> if [is valid currency code] [the specified code]; otherwise, <c>false</c>.</returns>
        public static bool IsValidCurrencyCode(string code)
        {
            return currency_dic.ContainsKey( code );
        }

        /// <summary>
        /// Gets the symbol for the specified currency code
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="InvalidCurrencyCodeException"></exception>
        public static string GetSymbolFor(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return string.Empty;

            world_currency wc;

            if (!currency_dic.TryGetValue(code.ToUpperInvariant(), out wc))
                throw new InvalidCurrencyCodeException(code);

            return wc.Symbol;
        }

        public static string GetNameFor(string code)
        {
            world_currency wc;

            if (!currency_dic.TryGetValue(code.ToUpperInvariant(), out wc))
                throw new InvalidCurrencyCodeException(code);

            return wc.Name;
        }

        public static List<NameValueStringPair> GetAllCurrencies()
        {
            var list = new List<NameValueStringPair>();
            foreach (var entry in currency_dic)
                list.Add(new NameValueStringPair(entry.Value.Name, entry.Value.Code));

            var usd = list.FirstOrDefault(x => x.Value == "USD");
            var eur = list.FirstOrDefault(x => x.Value == "EUR");
            var cad = list.FirstOrDefault(x => x.Value == "CAD");
            var gbp = list.FirstOrDefault(x => x.Value == "GBP");

            list.Remove(usd);
            list.Remove(eur);
            list.Remove(cad);
            list.Remove(gbp);

            list.Insert(0, gbp);
            list.Insert(0, cad);
            list.Insert(0, eur);
            list.Insert(0, usd);
            return list;
        }

        private struct world_currency
        {
            private readonly string _code;
            private readonly string _symbol;
            private readonly string _name;


            public world_currency(string code, string symbol, string name)
            {
                _code = code;
                _symbol = symbol;
                _name = name;
            }

            public string Code
            {
                get { return _code; }
            }

            public string Symbol
            {
                get { return _symbol; }
            }

            public string Name
            {
                get { return _name; }
            }

            public override string ToString()
            {
                return string.Format("{0} {1}/{2}",
                    _name, _symbol, _code);
            }
        }

      
    }
}
