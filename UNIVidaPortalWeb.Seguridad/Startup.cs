using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Common.Token.Src;
using UNIVidaPortalWeb.Seguridad.Respositories;
using UNIVidaPortalWeb.Seguridad.Services;

namespace UNIVidaPortalWeb.Seguridad
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Aquí puedes agregar servicios como AddJwtCustomized, AddControllers, etc.
           // services.AddJwtCustomized(Configuration);  // Agregar el servicio de JWT

            // Otros servicios que necesites
            services.AddControllers();
            services.AddDbContext<ContextDatabase>(
               opt =>
               {
                   opt.UseMySQL(Configuration["mysql:cn"]);
               });
            services.AddScoped<IAccessService, AccessService>();
            services.Configure<JwtOptions>(Configuration.GetSection("jwt"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configurar el pipeline de middleware
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

}
