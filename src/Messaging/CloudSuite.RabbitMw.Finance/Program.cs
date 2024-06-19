using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CloudSuite.RabbitMw.Finance;
using CloudSuite.RabbitMw.Finance.Producers;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .AddEnvironmentVariables();
    })
    .ConfigureServices((context, services) =>
    {
        // Bind RabbitMqSettings from configuration
        services.Configure<RabbitMqSettings>(context.Configuration.GetSection("RabbitMqSettings"));
        services.AddSingleton<AddressProducer>();
        
        // Configure logging
        services.AddLogging();
    })
    .Build();

await host.RunAsync();