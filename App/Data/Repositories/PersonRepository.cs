using Common;
using Dapper;
using Data.Contracts;
using Entities;
using Entities.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;
        public PersonRepository(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }
        public async Task<Person> Add(Person entity)
        {
            var connection = _sqlConnectionFactory.GetOpenConnection();
            var inserted =await connection.QuerySingleAsync<Person>(DatabaseStoreProcedure.InsertPerson, new { entity.Age, entity.FirstName, entity.LastName }, commandType: System.Data.CommandType.StoredProcedure);
            return inserted;
        }

        public async Task<int> Delete(int id)
        {
            var connection = _sqlConnectionFactory.GetOpenConnection();
            var affectedRows = await connection.ExecuteAsync(DatabaseStoreProcedure.DeletePerson, new { Id = id }, commandType: System.Data.CommandType.StoredProcedure);
            return affectedRows;
        }

        public async Task<Person> Get(int id)
        {
            var connection = _sqlConnectionFactory.GetOpenConnection();
            var result = await connection.QueryAsync<Person>(DatabaseStoreProcedure.GetPerson, new { Id = id }, commandType: System.Data.CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            var connection = _sqlConnectionFactory.GetOpenConnection();
            var result = await connection.QueryAsync<Person>(DatabaseStoreProcedure.GetPeople, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public async Task<Person> Update(Person entity)
        {
            var connection = _sqlConnectionFactory.GetOpenConnection();
            var inserted =await connection.QuerySingleAsync<Person>(DatabaseStoreProcedure.UpdatePerson, entity, commandType: System.Data.CommandType.StoredProcedure);
            return inserted;
        }
    }
}
