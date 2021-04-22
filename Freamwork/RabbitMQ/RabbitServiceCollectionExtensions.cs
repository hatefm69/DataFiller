﻿using Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.ObjectPool;
using RabbitMQ.Client;

namespace WebFramework.RabbitMQ
{
    public static class RabbitServiceCollectionExtensions
    {
        public static IServiceCollection AddRabbit(this IServiceCollection services, IConfiguration configuration, RabbitOptions rabbitConfig)
        {
            services.Configure<RabbitOptions>((x) =>
            {
                x = rabbitConfig;
            });

            services.AddSingleton<ObjectPoolProvider, DefaultObjectPoolProvider>();
            services.AddSingleton<IPooledObjectPolicy<IModel>, RabbitModelPooledObjectPolicy>(x => new RabbitModelPooledObjectPolicy(rabbitConfig));

            services.AddSingleton<IRabbitManager, RabbitManager>();

            return services;
        }
    }
}
