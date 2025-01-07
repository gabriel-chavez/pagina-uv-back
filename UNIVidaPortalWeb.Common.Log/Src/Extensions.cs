using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace UNIVidaPortalWeb.Common.Log.Src
{
    public static class Extensions
    { 
        private static readonly string SectionName = "logseq";
        public static void UseLogSeq(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {

                 IConfiguration configuration = scope.ServiceProvider.GetService<IConfiguration>();

                var options = configuration.GetOptions<LogOptions>(SectionName);
                //var options = scope.ServiceProvider.GetService<IOptions<LogOptions>>();

                if (options.Enabled)
                {
                    var loggerFactory = scope.ServiceProvider.GetService<ILoggerFactory>();
                    loggerFactory.AddSeq(options.Url, apiKey: options.Token);
                }
            }
        }

    }
}
