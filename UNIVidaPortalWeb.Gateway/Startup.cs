using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using UNIVidaPortalWeb.Common.Token.Src;

namespace UNIVidaPortalWeb.Gateway
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
            //app.UseRouting();

            //// Activa la autenticación y autorización
            //app.UseAuthentication();
            //app.UseAuthorization();

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
