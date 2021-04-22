using Autofac;
using Common;
using DataFiller.Job;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFramework.Configuration;
using WebFramework.MiddleWares;
using WebFramework.RabbitMQ;

namespace DataFiller
{
    public class Startup
    {
        private readonly SiteSettings _siteSetting;
        private const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        

            _siteSetting = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
 

            services.Configure<SiteSettings>(Configuration.GetSection(nameof(SiteSettings)));
 
            services.AddRabbit(Configuration, _siteSetting.RabbitMQSettings);
 
            return services.BuildAutofacServiceProvider(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCustomExceptionHandler();
        }


        public void ConfigureContainer(ContainerBuilder builder)
        {
            //builder.RegisterType<QuartzWrapper>().As<IQuartzWrapper>().SingleInstance();
            //builder.Register(provider => new JobFactory(provider)).As<IJobFactory>().InstancePerDependency();
            //builder.RegisterType<JobClass>().As<IJob>().InstancePerDependency();


        }

    }
}
