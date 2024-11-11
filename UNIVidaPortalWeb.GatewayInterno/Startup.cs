using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using UNIVidaPortalWeb.Common.Token.Src;

namespace UNIVidaPortalWeb.GatewayInterno
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Configuración de servicios
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddJwtCustomized("MY-KEY-JWT");

            services.AddOcelot();

        }

        // Configuración del pipeline de middleware
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Habilitar Swagger UI
            app.Map("/swagger/v1/swagger.json", b =>
            {
                b.Run(async x => {
                    var json = File.ReadAllText("swagger.json");
                    await x.Response.WriteAsync(json);
                });
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ocelot");
            });

            // Habilitar Ocelot
            app.UseRouting();

            app.UseOcelot().Wait();

           
        }
    }
}
