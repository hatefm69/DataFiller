using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Elasticsearch;
using Serilog.Sinks.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Reflection;
using WebFramework;

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
            //Serilog.Log.Logger = CreateSerilogLogger(configuration);

            try
            {

                CreateHostBuilder(args, configuration).Build().Run();
            }
            catch (Exception ex)
            {
                Serilog.Log.Fatal(ex, "Program terminated unexpectedly ({ApplicationContext})!", "asd");

                ErrorHandlerStartApp.WriteInFile(ex);
                //Console.WriteLine(ex.ToJson());
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static IHostBuilder CreateHostBuilder(string[] args, IConfigurationRoot configuration) =>
            Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory()) //<-like yours
            .ConfigureAppConfiguration(builder =>
            {
                builder.Sources.Clear();
                builder.AddConfiguration(configuration);
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
                webBuilder.UseSerilog((hostingContext, loggerConfig) =>
                loggerConfig.ReadFrom
                .Configuration(hostingContext.Configuration));
            })
            .ConfigureWebHost(config =>
            {
                config.UseUrls("http://*:5051");
            });

 
    }

}
