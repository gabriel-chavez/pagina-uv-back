using UNIVidaPortalWeb.Convocatorias;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddNacosConfiguration(builder.Configuration.GetSection("nacosConfig"));


// Crear instancia de Startup
var startup = new Startup(builder.Configuration);

// Llamar a ConfigureServices
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Llamar a Configure
startup.Configure(app, app.Environment);

app.Run();