using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Microbots.Common.Helpers
{
    public static class ReflectionHelper
    {
        public static string GetPropertyName<T>(Expression<Func<T>> expression)
        {
            var body = (MemberExpression)expression.Body;
            return body.Member.Name;
        }

        public static string GetPropertyName<T, TR>(Expression<Func<T, TR>> expression)
        {
            var body = expression.Body as MemberExpression;
            if (body != null)
            {
                return body.Member.Name;
            }
            var op = ((UnaryExpression)expression.Body).Operand;
            Debug.Assert(op is MemberExpression);
            return ((MemberExpression)op).Member.Name;
        }
    }
}
