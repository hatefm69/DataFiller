using Common;
using Common.Utilities;
using Entities.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ServiceStack.Redis;
using System.Threading.Tasks;

namespace WebFramework.RabbitMQ
{
    public class RedisSaveDataStrategy : IRedisSaveDataStrategy, ITransientDependency
    {
        private ILogger<RedisSaveDataStrategy> _logger;
        private SiteSettings _siteSettings;

        public RedisSaveDataStrategy(ILogger<RedisSaveDataStrategy> logger, IOptions<SiteSettings> siteSettings)
        {
            _logger = logger;
            _siteSettings = siteSettings.Value;
        }
        public async Task<Person> Execute(Person person)
        {
            using (var connection = new RedisClient(_siteSettings.Redis.Host, _siteSettings.Redis.Port))
            {
                var count = connection.Keys($"{_siteSettings.Redis.Key}*").Length;
                var result = connection.Set($"{_siteSettings.Redis.Key}:Id:{count}", person);

                _logger.LogInformation($"Added To Redis {_siteSettings.Redis.Key}:Id:{count} => {person.ToJson()}");
            }
            return person;
        }
    }
}
