using Common;
using Common.Utilities;
using Data.Contracts;
using Domain.Database;
using Entities.Models;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Services.Database.Sql
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
