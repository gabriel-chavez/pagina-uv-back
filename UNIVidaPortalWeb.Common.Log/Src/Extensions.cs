using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace UNIVidaPortalWeb.Common.Log.Src
{
    public static class Extensions
    {
        private static readonly string SerilogSection = "Serilog:WriteTo";
        private static readonly string LogSeqSection = "logseq";

        public static void UseLogSeq(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                IConfiguration configuration = scope.ServiceProvider.GetService<IConfiguration>();
                var loggerFactory = scope.ServiceProvider.GetService<ILoggerFactory>();

                // 1. Verificar si Seq está configurado en Serilog
                var seqConfig = configuration.GetSection(SerilogSection)
                                             .GetChildren()
                                             .FirstOrDefault(x => x["Name"] == "Seq");

                if (seqConfig != null &&
                    bool.TryParse(seqConfig["Args:enabled"], out var isEnabled) &&
                    isEnabled)
                {
                    // Configuración desde Serilog:WriteTo
                    var serverUrl = seqConfig["Args:serverUrl"];
                    var apiKey = seqConfig["Args:apiKey"];

                    loggerFactory.AddSeq(serverUrl, apiKey: apiKey);
                }
                else
                {
                    // Si no existe en Serilog, usar logseq como fallback
                    var options = configuration.GetOptions<LogOptions>(LogSeqSection);

                    if (options != null && options.Enabled)
                    {
                        loggerFactory.AddSeq(options.Url, apiKey: options.Token);
                    }
                }
            }
        }
    }
}
