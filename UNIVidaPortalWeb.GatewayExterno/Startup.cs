using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using UNIVidaPortalWeb.Common.Token.Src;

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
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();

            }));
            services.AddRouting(r => r.SuppressCheckForUnhandledSecurityMetadata = true);
            /*End - Cors*/

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

            /*Start - Cors*/
            app.UseCors(clientPolicy);
            app.Use((context, next) =>
            {
                context.Items["__CorsMiddlewareInvoked"] = true;
                return next();
            });
            /*End - Cors*/

            app.UseOcelot().Wait();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
        }
    }

}
