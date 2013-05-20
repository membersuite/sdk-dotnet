using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Spring.Core.TypeResolution;
using Spring.Expressions;

namespace MemberSuite.SDK.Utilities
{
    public static class SpringExpression
    {
        static SpringExpression()
        {
            // make sure you can use regex in expressions
            TypeRegistry.RegisterType("Regex",typeof (Regex));
            _expressionCache = new ConcurrentDictionary<string, IExpression>();
        }

        private static ConcurrentDictionary<string, IExpression> _expressionCache;

        public static object GetValue( object context, string formulaToEvaluate )
        {
            return GetValue(context, formulaToEvaluate, null  );
        }

        public static object GetValue( object context, string formulaToEvaluate, IDictionary variables )
        {
            if (formulaToEvaluate == null) throw new ArgumentNullException("formulaToEvaluate");

            IExpression expr = GetExpressionFor(formulaToEvaluate);

            if (variables != null) return expr.GetValue(context, variables);

            return expr.GetValue(context);
        }

        public static IExpression GetExpressionFor(string formulaToEvaluate)
        {
            IExpression expr;


            if (!_expressionCache.TryGetValue(formulaToEvaluate, out expr)) // let's parse it - this is expensive
            {
                expr = Expression.Parse(formulaToEvaluate);

                _expressionCache[formulaToEvaluate] = expr;
            }
            return expr;
        }

        public static void SetValue(object o, string formulaToEvaluate, object value)
        {
            GetExpressionFor(formulaToEvaluate).SetValue(o, value);
        }
    }
}
