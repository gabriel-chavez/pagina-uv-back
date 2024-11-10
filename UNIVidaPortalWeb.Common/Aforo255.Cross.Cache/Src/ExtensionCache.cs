using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aforo255.Cross.Cache.Src
{
    public class ExtensionCache : IExtensionCache
    {
        private readonly IConfiguration _configuration;
        private readonly IDistributedCache _distributedCache;

        public ExtensionCache(IConfiguration configuration, IDistributedCache distributedCache)
        {
            _configuration = configuration;
            _distributedCache = distributedCache;
        }
        public T GetData<T>(string key)
        {
            string _cache = _distributedCache.GetString(key);
            if (_cache == null)
                return default;
            T response = JsonSerializer.Deserialize<T>(_cache);
            return response;
        }

        public void SetData<T>(T TEntity, string key, int lifeTimeInMinutes)
        {
            var options = new DistributedCacheEntryOptions()
                               .SetSlidingExpiration(TimeSpan.FromMinutes(lifeTimeInMinutes));

            _distributedCache.SetString(key,
                JsonSerializer.Serialize(TEntity), options);
        }
    }
}
