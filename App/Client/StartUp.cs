using Autofac;
using Common;
using Data;
using Data.Contracts;
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
        private const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            _siteSetting = configuration.GetSection(nameof(SiteSettings)).Get<SiteSettings>();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<ApplicationDbContext>());

            services.AddDbContext(Configuration);

            services.Configure<SiteSettings>(Configuration.GetSection(nameof(SiteSettings)));

            services.AddRabbit(Configuration, _siteSetting.RabbitMQSettings);

            services.AddSingleton<IRpcClientQueue, RpcClientQueue>();

            services.BuildAutofacServiceProvider(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IRpcClientQueue rpcClientQueue)
        {
            app.UseCustomExceptionHandler();

            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
    

                var dataInitializer = scope.ServiceProvider.GetRequiredService<IRpcClientQueue>();

                //foreach (var dataInitializer in dataInitializers)
                    dataInitializer.Get();
            }

        }


        public void ConfigureContainer(ContainerBuilder builder)
        {
            //builder.RegisterType<QuartzWrapper>().As<IQuartzWrapper>().SingleInstance();
            //builder.Register(provider => new JobFactory(provider)).As<IJobFactory>().InstancePerDependency();
            //builder.RegisterType<JobClass>().As<IJob>().InstancePerDependency();


        }

    }
}
