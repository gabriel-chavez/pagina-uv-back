using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Text.Json.Serialization;
using System.Text.Json;
using UNIVidaPortalWeb.Noticias.Exceptions;
using UNIVidaPortalWeb.Noticias.Repositories;
using UNIVidaPortalWeb.Noticias.Services.NoticiasServices;
using UNIVidaPortalWeb.Noticias.Services.ParametricasServices;
using UNIVidaPortalWeb.Common.Tracing.Src;
using UNIVidaPortalWeb.Common.Metric.Registry;

namespace UNIVidaPortalWeb.Noticias
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
                options.Filters.Add<GlobalExceptionFilter>();
                options.Filters.Add<ValidationFilter>();
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
            services.AddDbContext<DbContextNoticias>(options =>
            {
                options.UseNpgsql(Configuration["cn:postgresNoticias"]).EnableSensitiveDataLogging();
            });
            /*Start - Tracer distributed*/
            services.AddJaeger();
            services.AddOpenTracing();
            /*End - Tracer distributed*/
            /*Start Metrics*/
            services.AddTransient<IMetricsRegistry, MetricsRegistry>();
            /*End Metrics*/

            // Registro de servicios
            services.AddScoped<INoticiaService, NoticiaService>();
            services.AddScoped<IRecursoService, RecursoService>();
            services.AddScoped<IParCategoriaService, ParCategoriaService>();
            services.AddScoped<IParEstadoService, ParEstadoService>();
            services.AddScoped<IParTipoRecursoService, ParTipoRecursoService>();


            services.AddAutoMapper(typeof(Program));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Inicializar la base de datos
            //using (var scope = app.ApplicationServices.CreateScope())
            //{
            //    var services = scope.ServiceProvider;
            //    try
            //    {
            //        var context = services.GetRequiredService<DbContextNoticias>();
            //        DbInitializer.Initialize(context);
            //    }
            //    catch (Exception ex)
            //    {
            //        var logger = services.GetRequiredService<ILogger<Program>>();
            //        logger.LogError(ex, "An error occurred creating the DB.");
            //    }
            //}

            Log.Information("Iniciando la aplicación...");
            app.UseMiddleware<ExceptionMiddleware>();
           // if (env.IsDevelopment())
            //{
                app.UseSwagger();
                app.UseSwaggerUI();
            //}
            app.UseRouting();
           // app.UseCors("AllowSpecificOrigin");


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
