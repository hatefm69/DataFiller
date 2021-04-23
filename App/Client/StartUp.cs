using Autofac;
using Common;
using Data.Contracts;
using Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebFramework.Configuration;
using WebFramework.MiddleWares;
using WebFramework.RabbitMQ;

namespace DataFiller
{
    public class Startup
    {
        private readonly SiteSettings _siteSetting;
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            _siteSetting = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext(Configuration);

            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IUnitOfWorkDapper, UnitOfWorkDapper>();

            services.Configure<SiteSettings>(Configuration.GetSection(nameof(SiteSettings)));

            services.AddHostedService<Worker>();
            services.BuildAutofacServiceProvider(Configuration);
            services.AddRabbit(Configuration, _siteSetting.RabbitMQSettings);
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
