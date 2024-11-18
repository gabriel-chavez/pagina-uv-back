using UNIVidaPortalWeb.GatewayInterno;
using UNIVidaPortalWeb.Common.Metric.Metrics;



Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((hostingContext, config) =>
    {
        var env = hostingContext.HostingEnvironment;

        // Configurar archivos de configuración
        config
            .AddJsonFile($"ocelot.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();
    })
    .ConfigureWebHostDefaults(webHostBuilder =>
    {
        // Configurar AppMetrics
        webHostBuilder.UseAppMetrics();

        // Configurar la clase Startup
        webHostBuilder.UseStartup<Startup>();
    })
    .Build()
    .Run();