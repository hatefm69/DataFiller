using Dapper;
using Data.Contracts;
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
        private readonly IConfiguration _configuration;

        public PersonRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> Add(Person entity)
        {
            entity.CreateDm = DateTime.Now;
            var sql = "INSERT INTO People (FirstName, LastName, Age) Values (@FirstName, @LastName, @Age);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("SqlServer")))
            {
                connection.Open();
                var affectedRows =  connection.Execute(sql, entity);
                return affectedRows;
            }
        }

        public async Task<int> Delete(int id)
        {
            var sql = "DELETE FROM People WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("SqlServer")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<Person> Get(int id)
        {
            var sql = "SELECT * FROM People WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("SqlServer")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Person>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            var sql = "SELECT * FROM People;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("SqlServer")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Person>(sql);
                return result;
            }
        }

        public async Task<int> Update(Person entity)
        {
            entity.LastUpdateDm = DateTime.Now;
            var sql = "UPDATE People SET FirstName = @FirstName, LastName = @LastName, Age = @Age WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("SqlServer")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }
    }
}
