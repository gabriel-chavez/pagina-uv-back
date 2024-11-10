using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aforo255.Cross.Cache.Src
{
    public static class Extensions
    {
        private static readonly string SectionName = "redis";

        public static IServiceCollection AddRedis(this IServiceCollection services)
        {
            IConfiguration configuration;
            using (var serviceProvider = services.BuildServiceProvider())
            {
                configuration = serviceProvider.GetService<IConfiguration>();
            }

            var options = configuration.GetOptions<RedisOptions>(SectionName);
            services.AddDistributedRedisCache(o =>
            {
                o.Configuration = options.ConnectionString;              
            });
             
            return services;
        }
    }
}
