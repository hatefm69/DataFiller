﻿using Autofac;
using Common;
using Data;
using Data.Contracts;
using Data.Repositories;
using Domain.Database;
using Domain.Database.Redis;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Database.Redis;
using Services.Database.Sql;
using WebFramework.BackgroundWorks;
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
            services.AddSingleton<ISqlConnectionFactory>(new SqlConnectionFactory(Configuration.GetConnectionString("SqlServer")));
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IUnitOfWorkDapper, UnitOfWorkDapper>();
            services.AddTransient<IRedisSaveDataStrategy, RedisSaveDataStrategy>();
            services.AddTransient<ISqlServerSaveDataStrategy, SqlServerSaveDataStrategy>();

            services.Configure<SiteSettings>(Configuration.GetSection(nameof(SiteSettings)));

            services.AddHostedService<ListenToServiceWorker>();
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
