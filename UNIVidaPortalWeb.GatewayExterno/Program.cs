using UNIVidaPortalWeb.GatewayExterno;
using UNIVidaPortalWeb.Common.Metric.Metrics;

Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((hostingContext, config) =>
    {
        var env = hostingContext.HostingEnvironment;
        var envFilePath = Path.Combine(Directory.GetCurrentDirectory(), $"ocelot.{env.EnvironmentName}.json");

        if (File.Exists(envFilePath))
        {
            config.AddJsonFile(envFilePath, optional: false, reloadOnChange: true);
        }
        else
        {
            config.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
        }

        config.AddEnvironmentVariables();
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