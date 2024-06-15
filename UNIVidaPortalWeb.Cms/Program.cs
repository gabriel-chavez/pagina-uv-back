using Microsoft.EntityFrameworkCore;
using Serilog;
using UNIVidaPortalWeb.Cms.Data;
using UNIVidaPortalWeb.Cms.Exceptions;
using UNIVidaPortalWeb.Cms.Repositories;
using UNIVidaPortalWeb.Cms.Services.CatalogoServices;
using UNIVidaPortalWeb.Cms.Services.DatoServices;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using UNIVidaPortalWeb.Cms.Services.RecursoServices;


var builder = WebApplication.CreateBuilder(args);


// Limpiar proveedores de logging predeterminados
builder.Logging.ClearProviders();
// Configurar Serilog
//Log.Logger = new LoggerConfiguration()
//    .ReadFrom.Configuration(builder.Configuration)
//    .Enrich.FromLogContext()
//    .WriteTo.Console()
//    .CreateLogger();
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateLogger();

Log.Information("Iniciando la aplicación...");

// Usar Serilog como el proveedor de logging
builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddControllers(options =>
{
    options.Filters.Add<GlobalExceptionFilter>();
    options.Filters.Add<ValidationFilter>();
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure database context

builder.Services.AddDbContext<ContextDatabase>(options =>
{
    options.UseNpgsql(builder.Configuration["postgres:cn"]);
});


// Register the PaginaDinamicaService
builder.Services.AddScoped<IPaginaDinamicaService, PaginaDinamicaService>();
builder.Services.AddScoped<IRecursoService, RecursoService>();
builder.Services.AddScoped<IDatoService, DatoService>();
builder.Services.AddScoped<IBannerPaginaDinamicaService, BannerPaginaDinamicaService>();
builder.Services.AddScoped<ICatTipoRecursoService, CatTipoRecursoService>();
builder.Services.AddScoped<ICatTipoSeccionService, CatTipoSeccionService>();
builder.Services.AddScoped<ISeccionService, SeccionService>();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Ensure the database is created and seed data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ContextDatabase>();
        DbInitializer.Initialize(context);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }
}
Log.Information("Iniciando la aplicación.2..");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
