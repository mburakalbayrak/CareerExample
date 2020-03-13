using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Cache
{
    public class CacheProvider : ICacheProvider
    {
        private readonly MemoryCache _cache;

        public void Set(string key, object value, int expireAsMiliseconds)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(key)); //key değerinin null veya boş olmadığından emin ol, yoksa exception fırlat
            System.Diagnostics.Contracts.Contract.Assert(value != null);  //value değerinin null olmadığından emin ol, yoksa exception fırlat
            System.Diagnostics.Contracts.Contract.Assert(expireAsMiliseconds > 0); //expireAsMiliseconds değerinin 0'dan büyük olduğuna emin ol, yoksa exception fırlat
            if (IsExist(key))
            {
                Remove(key);
            }

            _cache.Set(key, value, DateTimeOffset.Now.AddMilliseconds(expireAsMiliseconds));
        }

        public T Get<T>(string key)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(key)); //key değerinin null veya boş olmadığından emin ol, yoksa exception fırlat
            return (T)_cache.Get(key);
        }

        public void Remove(string key)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(key)); //key değerinin null veya boş olmadığından emin ol, yoksa exception fırlat
            _cache.Remove(key);
        }

        public bool IsExist(string key)
        {
            System.Diagnostics.Contracts.Contract.Assert(!string.IsNullOrEmpty(key)); //key değerinin null veya boş olmadığından emin ol, yoksa exception fırlat
            return _cache.Equals(key);
        }
    }
}
