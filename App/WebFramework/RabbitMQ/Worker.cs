using Common;
using Common.Utilities;
using Data.Contracts;
using Entities.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ServiceStack.Redis;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebFramework.RabbitMQ
{
    public abstract class ScopedBackgroundService : BackgroundService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public ScopedBackgroundService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                await ExecuteInScope(scope.ServiceProvider, stoppingToken);
            }
        }

        public abstract Task ExecuteInScope(IServiceProvider serviceProvider, CancellationToken stoppingToken);
    }


    public class Worker : ScopedBackgroundService
    {
        private readonly SiteSettings _siteSettings;
        private readonly ILogger<Worker> _logger;
        private readonly IUnitOfWorkDapper _unitOfWork;
        private readonly string _queueName;
        private IConnection connection;
        private IModel channel;
        private AsyncEventingBasicConsumer consumer;

        public Worker(ILogger<Worker> logger, IOptions<SiteSettings> siteSettings, IUnitOfWorkDapper unitOfWork, IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
            _siteSettings = siteSettings.Value;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _queueName = _siteSettings.RabbitMQSettings.QueueName;
            var factory = new ConnectionFactory()
            {
                HostName = _siteSettings.RabbitMQSettings.HostName,
                Password = _siteSettings.RabbitMQSettings.Password,
                Port = _siteSettings.RabbitMQSettings.Port,
                UserName = _siteSettings.RabbitMQSettings.UserName,
                 DispatchConsumersAsync = true
            };
            connection = factory.CreateConnection();
            channel = connection.CreateModel();

            _logger.LogError("Listen To RabbitMQ");
            channel.QueueDeclare(queue: _queueName,
                                durable: false,
                                exclusive: false,
                                autoDelete: false,
                                arguments: null);

            consumer = new AsyncEventingBasicConsumer(channel);

        }

        public override Task ExecuteInScope(IServiceProvider serviceProvider, CancellationToken stoppingToken)
        {
             consumer.Received += async(model, ea) =>
            {
                _logger.LogError("Received From RabbitMQ");
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                //Console.WriteLine(" [x] Received {0}", message);

                #region SqlServer
                var person = message.FromJson<Person>();
                person =await _unitOfWork.People.Add(person);
                _logger.LogError($"Added To SqlServer people:Id:{person.Id} => {person.ToJson()}");
                #endregion
                #region Redis
                using (var connection = new RedisClient(_siteSettings.Redis.Host, _siteSettings.Redis.Port))
                {
                    var count = connection.Keys($"{_siteSettings.Redis.Key}*").Length;
                    var result = connection.Set($"{_siteSettings.Redis.Key}:Id:{count}", person);

                    _logger.LogError($"Added To Redis {_siteSettings.Redis.Key}:Id:{count} => {person.ToJson()}");
                }
                #endregion
            };
            channel.BasicConsume(queue: _queueName,
                                 autoAck: true,
                                 consumer: consumer);

            return Task.CompletedTask;
        }
    }
}
