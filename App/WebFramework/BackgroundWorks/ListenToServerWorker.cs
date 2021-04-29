using Common;
using Common.Utilities;
using Domain.Database;
using Domain.Database.Redis;
using Entities.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebFramework.BackgroundWorks
{
    public class ListenToServerWorker : ScopedBackgroundService
    {
        private readonly SiteSettings _siteSettings;
        private readonly ILogger<ListenToServerWorker> _logger;
        private readonly string _queueName;
        private readonly DefaultObjectPool<IModel> _objectPool;
        private IConnection connection;
        private IModel channel;
        private AsyncEventingBasicConsumer consumer;
        private ISaveDataStrategy SqlServer;
        private ISaveDataStrategy Redis;

        public ListenToServerWorker(ILogger<ListenToServerWorker> logger
            , IRedisSaveDataStrategy redisSaveDataStrategy
            , ISqlServerSaveDataStrategy sqlServer,
            IOptions<SiteSettings> siteSettings, IServiceScopeFactory serviceScopeFactory
            , IPooledObjectPolicy<IModel> objectPolicy
            ) : base(serviceScopeFactory)
        {

            SqlServer = sqlServer;
            Redis = redisSaveDataStrategy;

            _siteSettings = siteSettings.Value;
            _logger = logger;
            _queueName = _siteSettings.RabbitMQSettings.QueueName;

            _objectPool = new DefaultObjectPool<IModel>(objectPolicy, Environment.ProcessorCount * 2);

            channel = _objectPool.Get();

            _logger.LogInformation("Listen To RabbitMQ");
            channel.QueueDeclare(queue: _queueName,
                                durable: false,
                                exclusive: false,
                                autoDelete: false,
                                arguments: null);

            consumer = new AsyncEventingBasicConsumer(channel);

        }

        public override Task ExecuteInScope(IServiceProvider serviceProvider, CancellationToken stoppingToken)
        {
            consumer.Received += async (model, ea) =>
            {
                try
                {
                    string message = ReadMessage(ea);
                    var person = message.FromJson<Person>();
                    person = await SqlServer.Execute(person);
                    person = await Redis.Execute(person);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.ToJson());
                }
            };
            channel.BasicConsume(queue: _queueName,
                                 autoAck: true,
                                 consumer: consumer);

            return Task.CompletedTask;
        }
        private string ReadMessage(BasicDeliverEventArgs ea)
        {
            _logger.LogInformation("Received From RabbitMQ");
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            return message;
        }
    }
}
