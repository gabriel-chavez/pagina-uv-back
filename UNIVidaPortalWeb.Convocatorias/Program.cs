using UNIVidaPortalWeb.Convocatorias;
using UNIVidaPortalWeb.Common.Metric.Metrics;

Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) =>
    {
        //// Configurar configuraciones adicionales (opcional)
        //config
        //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        //    .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", optional: true)
        //    .AddEnvironmentVariables();


        config.AddNacosConfiguration(config.Build().GetSection("nacosConfig"));
    })
    .ConfigureWebHostDefaults(webHostBuilder =>
    {
        // Llamar explícitamente a UseAppMetrics
        webHostBuilder.UseAppMetrics();

        // Vincular Startup para configurar servicios y middlewares
        webHostBuilder.UseStartup<Startup>();
    })
    .Build()
    .Run();
