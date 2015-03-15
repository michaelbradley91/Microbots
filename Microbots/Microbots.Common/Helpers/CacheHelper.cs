using System;
using System.Collections.Generic;

namespace Microbots.Common.Helpers
{
    public interface ICacheHelper
    {
        T Get<T>(string key, Func<T> getter, bool resetCache = false);
    }

    class CacheHelper : ICacheHelper
    {
        private Dictionary<string, object> Cache { get; set; }

        public CacheHelper()
        {
            Cache = new Dictionary<string, object>();
        }

        public T Get<T>(string key, Func<T> getter, bool resetCache = false)
        {
            if (resetCache || !Cache.ContainsKey(key))
            {
                Cache.Add(key, getter());
            }
            return (T)Cache[key];
        }

    }
}
