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
        public async Task<int> Add(Person entity)
        {
            entity.CreateDm = DateTime.Now;
            var connection = _sqlConnectionFactory.GetOpenConnection();
            var affectedRows = connection.Execute(DatabaseStoreProcedure.InsertPerson, entity, commandType: System.Data.CommandType.StoredProcedure);
            return affectedRows;
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

        public async Task<int> Update(Person entity)
        {
            entity.LastUpdateDm = DateTime.Now;
            var connection = _sqlConnectionFactory.GetOpenConnection();
            var affectedRows = await connection.ExecuteAsync(DatabaseStoreProcedure.UpdatePerson, entity, commandType: System.Data.CommandType.StoredProcedure);
            return affectedRows;
        }
    }
}
