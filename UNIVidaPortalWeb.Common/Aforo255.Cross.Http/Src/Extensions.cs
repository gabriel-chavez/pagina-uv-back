using Microsoft.Extensions.DependencyInjection;

namespace Aforo255.Cross.Http.Src
{
    public static class Extensions
    {
        public static IServiceCollection AddProxyHttp(this IServiceCollection services)
        {
            services.AddSingleton<IHttpClient, CustomHttpClient>();
            return services;
        }
    }
}
