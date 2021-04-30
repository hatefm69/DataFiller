using Common;
using Common.Utilities;
using Data.Contracts;
using Domain.Database.Redis;
using Entities.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ServiceStack.Redis;
using System.Threading.Tasks;

namespace Services.Database.Redis
{
    public class RedisSaveDataStrategy : IRedisSaveDataStrategy, ITransientDependency
    {
        private ILogger<RedisSaveDataStrategy> _logger;
        private SiteSettings _siteSettings;
        private IUnitOfWork _unitOfWork;

        public RedisSaveDataStrategy(ILogger<RedisSaveDataStrategy> logger, IOptions<SiteSettings> siteSettings, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _siteSettings = siteSettings.Value;
            _unitOfWork = unitOfWork;
        }
        public async Task<PersonEntity> Execute(PersonEntity person)
        {
           await _unitOfWork.RedisPeople.Add(person);
            _logger.LogInformation($"Added To Redis {_siteSettings.Redis.Key}:Id:{person.Id} => {person.ToJson()}");

            return person;
        }
    }
}
