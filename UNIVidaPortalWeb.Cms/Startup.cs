using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using Serilog;

using System.Text.Json;
using System.Text.Json.Serialization;
using UNIVidaPortalWeb.Cms.Data;
using UNIVidaPortalWeb.Cms.Exceptions;
using UNIVidaPortalWeb.Cms.Repositories;
using UNIVidaPortalWeb.Cms.Services;
using UNIVidaPortalWeb.Cms.Services.CatalogoServices;
using UNIVidaPortalWeb.Cms.Services.DatoServices;
using UNIVidaPortalWeb.Cms.Services.MenuServices;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using UNIVidaPortalWeb.Cms.Services.RecursoServices;
using UNIVidaPortalWeb.Cms.Services.SeguroServices;
using UNIVidaPortalWeb.Common.Metric.Registry;
using UNIVidaPortalWeb.Common.Tracing.Src;
using UNIVidaPortalWeb.Common.Log.Src;

namespace UNIVidaPortalWeb.Cms
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

            //CORS
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowSpecificOrigin",
            //        builder => builder.WithOrigins("http://localhost:3000", "http://localhost:3001")
            //                          .AllowAnyMethod()
            //                          .AllowAnyHeader());
            //});

            // Configuración de controladores y filtros
            services.AddControllers(options =>
            {
                options.Filters.Add<ValidationFilter>();
                options.Filters.Add<GlobalExceptionFilter>();                
            })
                .ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true; // Desactivar la validación predeterminada
            })
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            });

            // Configuración de Swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            // Configuración de contexto de base de datos
            services.AddDbContext<DbContextCms>(options =>
            {
                options.UseNpgsql(Configuration["cn:postgresCms"])
                .LogTo(Console.WriteLine, LogLevel.Information);  // Habilita el logging de BD
            });
            /*Start - Tracer distributed*/
            services.AddJaeger();
            services.AddOpenTracing();
            /*End - Tracer distributed*/
            /*Start Metrics*/
            services.AddTransient<IMetricsRegistry, MetricsRegistry>();
            /*End Metrics*/

            // Registro de servicios
            services.AddScoped<IPaginaDinamicaService, PaginaDinamicaService>();
            services.AddScoped<IRecursoService, RecursoService>();
            services.AddScoped<IDatoService, DatoService>();
            services.AddScoped<IBannerPaginaDinamicaService, BannerPaginaDinamicaService>();
            services.AddScoped<ICatTipoRecursoService, CatTipoRecursoService>();
            services.AddScoped<ICatTipoSeccionService, CatTipoSeccionService>();
            services.AddScoped<ISeccionService, SeccionService>();
            services.AddScoped<ISeguroService, SeguroService>();
            services.AddScoped<ISeguroDetalleService, SeguroDetalleService>();
            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped<IMenuPrincipalService, MenuPrincipalService>();
            services.AddScoped<ICatTipoSeguroService, CatTipoSeguroService>();
            services.AddScoped<ICatEstiloBannerService, CatEstiloBannerService>();
            services.AddScoped<ICatTipoBannerPaginaPrincipalService, CatTipoBannerPaginaPrincipalService>();
            services.AddScoped<IBannerPaginaPrincipalDetalleService, BannerPaginaPrincipalDetalleService>();
            services.AddScoped<IBannerPaginaPrincipalMaestroService, BannerPaginaPrincipalMaestroService>();

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            

            services.AddAutoMapper(typeof(Program));

          
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Inicializar la base de datos
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<DbContextCms>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }

            Log.Information("Iniciando la aplicación...");
            app.UseMiddleware<ExceptionMiddleware>();
          //  if (env.IsDevelopment())
            //{
                app.UseSwagger();
                app.UseSwaggerUI();
            //}
            app.UseRouting();

            //app.UseCors("AllowSpecificOrigin");


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //loggin

            app.UseLogSeq();
        }
    }

}
