using System;
using System.Linq.Expressions;

namespace Microbots.Helpers
{
    public static class ReflectionHelper
    {
        public static string GetPropertyName<T>(Expression<Func<T>> expression)
        {
            var body = (MemberExpression)expression.Body;
            return body.Member.Name;
        }
    }
}
