using System;
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
            var body = (MemberExpression)expression.Body;
            return body.Member.Name;
        }
    }
}
