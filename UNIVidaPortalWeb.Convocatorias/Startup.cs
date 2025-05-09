using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Serilog;
using UNIVidaPortalWeb.Common.Tracing.Src;
using UNIVidaPortalWeb.Convocatorias.Exceptions;
using UNIVidaPortalWeb.Convocatorias.Repositories;
using UNIVidaPortalWeb.Convocatorias.Services;
using UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices;
using UNIVidaPortalWeb.Convocatorias.Services.ParametricasServices;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Common.Metric.Registry;
using UNIVidaPortalWeb.Convocatorias.Utilities;
using Microsoft.Extensions.DependencyInjection;
using OpenTracing.Util;
using OpenTracing;


namespace UNIVidaPortalWeb.Convocatorias
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
                options.SuppressModelStateInvalidFilter = true; // Desactiva la validación predeterminada
            })
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; // Ignora ciclos de referencia
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore; // Ignora valores nulos al serializar
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver(); // Propiedades en camelCase
            });
            //.AddJsonOptions(options =>
            //{
            //    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            //    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            //    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            //});

            // Configuración de Swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            //interceptor de tracer
            services.AddScoped<TracingDbCommandInterceptor>();

            // Configuración de contexto de base de datos
            services.AddDbContext<DbContextConvocatorias>((serviceProvider, options) =>
            {                
                var tracingInterceptor = serviceProvider.GetRequiredService<TracingDbCommandInterceptor>();

                options.UseNpgsql(Configuration["cn:postgresConvocatorias"])
                       .AddInterceptors(tracingInterceptor) // Agrega el interceptor
                       .EnableSensitiveDataLogging()
                       .LogTo(Console.WriteLine, LogLevel.Information);
            });
            /*Start - Tracer distributed*/
            services.AddJaeger();
            services.AddOpenTracing();
            services.AddSingleton<ITracer>(sp => GlobalTracer.Instance);

            /*End - Tracer distributed*/
            /*Start Metrics*/
            // services.AddTransient<IMetricsRegistry, MetricsRegistry>();
            /*End Metrics*/

            // Registro de servicios
            //Postulantes
            services.AddScoped<ICapacitacionService, CapacitacionService>();
            services.AddScoped<IConocimientoIdiomaService, ConocimientoIdiomaService>();
            services.AddScoped<IConocimientoSistemasService, ConocimientoSistemasService>();
            services.AddScoped<IFormacionAcademicaService, FormacionAcademicaService>();
            services.AddScoped<IPostulanteService, PostulanteService>();
            services.AddScoped<IReferenciaLaboralService, ReferenciaLaboralService>();
            services.AddScoped<IReferenciaPersonalService, ReferenciaPersonalService>();
            services.AddScoped<IExperienciaLaboralService, ExperienciaLaboralService>();
            //Convocatoria
            services.AddScoped<IConvocatoriaService, ConvocatoriaService>();
            services.AddScoped<INotificacionService, NotificacionService>();
            services.AddScoped<IPostulacionService, PostulacionService>();
            services.AddScoped<IExperienciaPuntosService, ExperienciaPuntosService>();
            services.AddScoped<INivelFormacionPuntosService, NivelFormacionPuntosService>();
            //Parametrica
            services.AddScoped<IParEstadoConvocatoriaService, ParEstadoConvocatoriaService>();
            services.AddScoped<IParEstadoPostulacionService, ParEstadoPostulacionService>();
            services.AddScoped<IParIdiomaService, ParIdiomaService>();
            services.AddScoped<IParNivelConocimientoService, ParNivelConocimientoService>();
            services.AddScoped<IParNivelFormacionService, ParNivelFormacionService>();
            services.AddScoped<IParParentescoService, ParParentescoService>();
            services.AddScoped<IParProgramaService, ParProgramaService>();
            services.AddScoped<IParTipoCapacitacionService, ParTipoCapacitacionService>();
            

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
                    var context = services.GetRequiredService<DbContextConvocatorias>();
                    //   DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }

            Log.Information("Iniciando la aplicación...");
            app.UseMiddleware<ExceptionMiddleware>();
         //   if (env.IsDevelopment())
           // {
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
        }
    }
}
