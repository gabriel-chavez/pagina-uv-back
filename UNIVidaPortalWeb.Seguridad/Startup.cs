using Microsoft.EntityFrameworkCore;
using Serilog;
using UNIVidaPortalWeb.Common.Token.Src;
using UNIVidaPortalWeb.Seguridad.Exceptions;
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
            // Configurar Serilog
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .CreateLogger();

            Log.Information("Iniciando la aplicación...");

            // Usar Serilog como el proveedor de logging
            services.AddLogging(loggingBuilder =>
                loggingBuilder.ClearProviders().AddSerilog());

            // Otros servicios que necesites

            services.AddControllers(options =>
            {
                options.Filters.Add<ValidationFilter>();
                options.Filters.Add<GlobalExceptionFilter>();
            })
            .ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true; // Desactivar la validación predeterminada
            });

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
            app.UseMiddleware<ExceptionMiddleware>();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

}
