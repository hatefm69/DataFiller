using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.EventLog;
using Serilog;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DataFiller
{

    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .AddJsonFile("appsettings.json")
                .Build();

            CreateHostBuilder(args, configuration).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args, IConfigurationRoot configuration) =>
            Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory()) //<-like yours
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<Worker>()
                  .Configure<EventLogSettings>(config =>
                  {
                      config.LogName = "DataFillerRabitMQ Service";
                      config.SourceName = "DataFillerRabitMQ Service Source";
                  });
            })

            .ConfigureAppConfiguration(builder =>
            {
                builder.Sources.Clear();
                builder.AddConfiguration(configuration);
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
                webBuilder.UseSerilog((builder, logger) =>
                {
                    if (builder.HostingEnvironment.IsDevelopment())
                    {
                        logger.WriteTo.Console().MinimumLevel.Information();
                        logger.WriteTo.Elasticsearch().MinimumLevel.Information();
                    }
                    else if (builder.HostingEnvironment.IsProduction())
                    {
                        logger.WriteTo.Elasticsearch().MinimumLevel.Information();

                    }
                });
            })
            .ConfigureWebHost(config =>
            {
                config.UseUrls("http://*:5050");
            }).UseWindowsService();
    }

}
