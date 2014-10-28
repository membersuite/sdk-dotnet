using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Searching.Operations
{
    public static class Expr
    {
        public static Equals Equals( string field, object value )
        {
            return new Equals { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static DoesNotEqual DoesNotEqual (string field, object value)
        {
            return new DoesNotEqual { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static IsGreaterThanOrEqualTo IsGreaterThanOrEqualTo( string field, object value )
        {
            return new IsGreaterThanOrEqualTo { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static IsGreaterThan IsGreaterThan(string field, object value)
        {
            return new IsGreaterThan { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static IsLessThanOrEqual IsLessThanOrEqual(string field, object value)
        {
            return new IsLessThanOrEqual { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static IsLessThan IsLessThan(string field, object value)
        {
            return new IsLessThan { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static Contains Contains(string field, object value )
        {
            return new Contains { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static DoesNotContain DoesNotContain(string field, object value)
        {
            return new DoesNotContain() { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static StartsWith StartsWith(string field, object value)
        {
            return new StartsWith() { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static DoesNotStartWith DoesNotStartWith(string field, object value)
        {
            return new DoesNotStartWith() { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static EndsWith EndsWith(string field, object value)
        {
            return new EndsWith() { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static DoesNotEndWith DoesNotEndWith(string field, object value)
        {
            return new DoesNotEndWith() { FieldName = field, ValuesToOperateOn = new List<object> { value } };
        }

        public static SearchOperation IsBlank(string field)
        {
            return new IsBlank { FieldName = field };
        }

        public static SearchOperation IsNotBlank(string field)
        {
            return new IsNotBlank { FieldName = field };
        }

        public static SearchOperation IsBetween(string field, object rangeFrom, object rangeTo)
        {
            return new IsBetween { FieldName = field, ValuesToOperateOn = new List<object> { rangeFrom, rangeTo } };
        }

        public static SearchOperation IsNotBetween(string field, object rangeFrom, object rangeTo)
        {
            return new IsNotBetween { FieldName = field, ValuesToOperateOn = new List<object> { rangeFrom, rangeTo } };
        }

        public static SearchOperation IsOneOfTheFollowing(string field, List<string> listOfValues)
        {
            var so = new IsOneOfTheFollowing {FieldName = field, ValuesToOperateOn = new List<object>(listOfValues)};
            return so;
        }

        public static SearchOperation IsNotOneOfTheFollowing(string field, List<string> listOfValues)
        {
            var so = new IsNotOneOfTheFollowing {FieldName = field, ValuesToOperateOn = new List<object>(listOfValues)};
            return so;
        }

        public static SearchOperation ContainsOneOfTheFollowing(string field, List<string> listOfValues)
        {
            var so = new ContainsOneOfTheFollowing
                         {FieldName = field, ValuesToOperateOn = new List<object>(listOfValues)};
            return so;
        }

        public static SearchOperation DoesNotContainOneOfTheFollowing(string field, List<string> listOfValues)
        {
            var so = new DoesNotContainOneOfTheFollowing
                         {FieldName = field, ValuesToOperateOn = new List<object>(listOfValues)};
            return so;
        }

        public static SearchOperation StartsWithOneOfTheFollowing(string field, List<string> listOfValues)
        {
            var so = new StartsWithOneOfTheFollowing { FieldName = field, ValuesToOperateOn = new List<object>(listOfValues) };
            return so;
        }

        public static SearchOperation DoesNotStartWithOneOfTheFollowing(string field, List<string> listOfValues)
        {
            var so = new DoesNotStartWithOneOfTheFollowing { FieldName = field, ValuesToOperateOn = new List<object>(listOfValues) };
            return so;
        }

        public static SearchOperation EndsWithOneOfTheFollowing(string field, List<string> listOfValues)
        {
            var so = new EndsWithOneOfTheFollowing { FieldName = field, ValuesToOperateOn = new List<object>(listOfValues) };
            return so;
        }

        public static SearchOperation DoesNotEndWithOneOfTheFollowing(string field, List<string> listOfValues)
        {
            var so = new DoesNotEndWithOneOfTheFollowing { FieldName = field, ValuesToOperateOn = new List<object>(listOfValues) };
            return so;
        }

        public static SearchOperation Keyword(string field, string keyword)
        {
            var so = new Keyword { FieldName = field, ValuesToOperateOn = new List<object>{keyword} };
            return so;
        }

        public static SearchOperation NoKeyword(string field, string keyword)
        {
            var so = new NoKeyword { FieldName = field, ValuesToOperateOn = new List<object>{keyword} };
            return so;
        }
    }
}
