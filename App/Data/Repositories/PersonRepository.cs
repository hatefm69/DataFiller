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
            var sql = "INSERT INTO Tasks (Name, Description, Status, DueDate, DateCreated) Values (@Name, @Description, @Status, @DueDate, @DateCreated);";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }

        public async Task<int> Delete(int id)
        {
            var sql = "DELETE FROM Tasks WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<Person> Get(int id)
        {
            var sql = "SELECT * FROM Tasks WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Person>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            var sql = "SELECT * FROM Tasks;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Person>(sql);
                return result;
            }
        }

        public async Task<int> Update(Person entity)
        {
            entity.LastUpdateDm = DateTime.Now;
            var sql = "UPDATE Tasks SET Name = @Name, Description = @Description, Status = @Status, DueDate = @DueDate, DateModified = @DateModified WHERE Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }
    }
}
