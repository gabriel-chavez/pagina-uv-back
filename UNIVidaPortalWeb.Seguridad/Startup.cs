using Microsoft.EntityFrameworkCore;
using Serilog;
using UNIVidaPortalWeb.Common.Token.Src;
using UNIVidaPortalWeb.Seguridad.Exceptions;
using UNIVidaPortalWeb.Seguridad.Respositories;
using UNIVidaPortalWeb.Seguridad.Services;
using UNIVidaPortalWeb.Common.Tracing.Src;
using UNIVidaPortalWeb.Common.Metric.Registry;
using UNIVidaPortalWeb.Common.Http.Src;
using UNIVidaPortalWeb.Seguridad.Utilities;
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
            /*Start - Tracer distributed*/
            services.AddJaeger();
            services.AddOpenTracing();
            /*End - Tracer distributed*/
            /*Start Metrics*/
            services.AddTransient<IMetricsRegistry, MetricsRegistry>();
            /*End Metrics*/
            services.AddDbContext<ContextDatabase>(
               opt =>
               {
                   opt.UseMySQL(Configuration["cn:mysql"]);
               });
            services.AddScoped<IAccessService, AccessService>();
            services.Configure<JwtOptions>(Configuration.GetSection("jwt"));
            services.AddHttpClient();
            services.AddProxyHttp();
            // === REGISTRO DEL SERVICIO DE EMAIL ===
            //services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            //services.AddTransient<EmailService>();
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
