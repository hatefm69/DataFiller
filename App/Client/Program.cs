using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace DataFiller
{
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
            .ConfigureLogging((context, builder) => builder.AddSerilog())
            .ConfigureAppConfiguration(builder =>
            {
                builder.Sources.Clear();
                builder.AddConfiguration(configuration);
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseUrls("https://*:8081", "http://*:8080");
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
            });
    }

}
