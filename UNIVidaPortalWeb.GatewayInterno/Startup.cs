using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using UNIVidaPortalWeb.Common.Metric.Registry;
using UNIVidaPortalWeb.Common.Token.Src;
using UNIVidaPortalWeb.Common.Tracing.Src;

namespace UNIVidaPortalWeb.GatewayInterno
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        readonly string clientPolicy = "_clientPolicy";


        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Configuración de servicios
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddJwtCustomized("MY-KEY-JWT");

            services.AddOcelot();

            /*Start - Cors*/
            services.AddCors(o => o.AddPolicy(clientPolicy, builder =>
            {
                builder.WithOrigins("http://localhost:3000", "http://localhost:3001", "http://172.16.0.30:3000", "http://pagina-web.univida.bo:3000", "https://pagina-web.univida.bo:3000", "https://pagina.univida.bo", "http://192.168.13.59:3000")
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .AllowCredentials(); // Permite enviar cookies con las solicitudes
            }));
            //services.AddCors(o => o.AddPolicy(clientPolicy, builder =>
            //{
            //    builder.AllowAnyOrigin()
            //           .AllowAnyMethod()
            //           .AllowAnyHeader();

            //}));
            services.AddRouting(r => r.SuppressCheckForUnhandledSecurityMetadata = true);
            /*End - Cors*/
            /*Start - Tracer distributed*/
            services.AddJaeger();
            services.AddOpenTracing();
            /*End - Tracer distributed*/
            /*Start Metrics*/
            services.AddTransient<IMetricsRegistry, MetricsRegistry>();
            /*End Metrics*/
        }

        // Configuración del pipeline de middleware
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context, next) =>
            {
                // Verificar si la cookie "jwt" existe
                var token = context.Request.Cookies["jwt"];

                // Si la cookie contiene un token, agregarlo al encabezado Authorization
                if (!string.IsNullOrEmpty(token))
                {
                    context.Request.Headers["Authorization"] = $"Bearer {token}";
                    Console.WriteLine("Token extraído de la cookie: " + token);
                }
                else
                {
                    Console.WriteLine("No se encontró la cookie jwt.");
                }

                // Continuar con la siguiente parte del middleware
                await next();
            });
            //app.Use(async (context, next) =>
            //{
            //    var token = context.Request.Headers["Authorization"];
            //    if (!string.IsNullOrEmpty(token))
            //    {
            //        Console.WriteLine("Token recibido: " + token);
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se recibió token.");
            //    }

            //    await next();
            //});

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
            /*Start - Cors*/
            app.UseCors(clientPolicy);
            app.Use((context, next) =>
            {
                context.Items["__CorsMiddlewareInvoked"] = true;
                return next();
            });
            /*End - Cors*/

            app.UseOcelot().Wait();

           
        }
    }
}
