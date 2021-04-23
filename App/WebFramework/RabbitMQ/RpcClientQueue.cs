using Common;
using Common.Utilities;
using Data;
using Data.Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ServiceStack.Redis;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebFramework.RabbitMQ
{


    public class RpcClientQueue : IRpcClientQueue
    {
        private readonly IConnection connection;
        private readonly IModel channel;
        private readonly string replyQueueName;
        private readonly EventingBasicConsumer consumer;
        private readonly BlockingCollection<string> respQueue = new BlockingCollection<string>();
        private readonly IBasicProperties props;
        private IUnitOfWorkDapper _unitOfWork;
      
        public RpcClientQueue(IUnitOfWorkDapper unitOfWork)
          //  , ISqlConnectionFactory sqlConnectionFactory)
        {
            _unitOfWork = unitOfWork;
          
            var factory = new ConnectionFactory() { HostName = "localhost" };
            connection = factory.CreateConnection();
            channel = connection.CreateModel();


        }
        public void Get()
        {
            try
            {


                channel.QueueDeclare(queue: "hello",
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                var index = 0;
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] Received {0}", message);

                    #region SqlServer
                    var person = message.FromJson<Person>();
                    _unitOfWork.People.Add(person);
                    #endregion
                    index++;
                    #region Redis
                    using (var connection = new RedisClient())
                    {
                        var count= connection.Keys("people*").Length;
                        var result= connection.Set($"people:Id:{count}",person);
                    }
                    #endregion
                };
                channel.BasicConsume(queue: "hello",
                                     autoAck: true,
                                     consumer: consumer);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                Close();
            }
        }

        private void Close()
        {
            connection.Close();
        }
    }
}
