using UNIVidaPortalWeb.GatewayExterno;

var builder = WebApplication.CreateBuilder(args);

// Configurar archivos de configuración
builder.Configuration
    
    .AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();

// Crear una instancia de la clase Startup
var startup = new Startup(builder.Configuration);

// Llamar a ConfigureServices para configurar los servicios
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Llamar a Configure para configurar el middleware
startup.Configure(app, app.Environment);

app.Run();
