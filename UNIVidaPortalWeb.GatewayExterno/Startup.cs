﻿using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using UNIVidaPortalWeb.Common.Metric.Registry;
using UNIVidaPortalWeb.Common.Token.Src;
using UNIVidaPortalWeb.Common.Tracing.Src;
using UNIVidaPortalWeb.GatewayExterno.Middleware;



namespace UNIVidaPortalWeb.GatewayExterno
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
            /*Start - Cors*/
            services.AddCors(o => o.AddPolicy(clientPolicy, builder =>
            {
                builder.WithOrigins("http://localhost:3000", "http://localhost:3001", "http://172.16.0.30:3000", "http://pagina-web.univida.bo:3000", "https://pagina-web.univida.bo:3000", "https://pagina.univida.bo", "http://172.16.0.30:5000", "http://172.16.0.30:5001")
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

            services.AddOcelot();

        }

        // Configuración del pipeline de middleware
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Middleware para cifrar el JWT (firmar el JWT)
            app.UseMiddleware<MiddlewareCifradoJwt>();

            // Middleware para descifrar el JWT (verificar el JWT)

            app.UseMiddleware<MiddlewareDescifradoJwt>();


            // Habilitar Swagger UI
            app.Map("/swagger/v1/swagger.json", b =>
            {
                b.Run(async x =>
                {
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
