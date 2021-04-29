using Common;
using Common.Utilities;
using Data.Contracts;
using Entities.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFramework.RabbitMQ
{
    public class SqlServerSaveDataStrategy : ISqlServerSaveDataStrategy, ITransientDependency
    {
        private IUnitOfWorkDapper _unitOfWork;
        private ILogger<SqlServerSaveDataStrategy> _logger;

        public SqlServerSaveDataStrategy(ILogger<SqlServerSaveDataStrategy> logger, IUnitOfWorkDapper unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public async Task<Person> Execute(Person person)
        {
            person = await _unitOfWork.People.Add(person);
            _logger.LogInformation($"Added To SqlServer people:Id:{person.Id} => {person.ToJson()}");
            return person;
        }
    }
}
