using Data.Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;

namespace Services.DataInitializer
{
    /// <summary>
    /// کلاس برای تولید محتوای قرارداد 
    /// </summary>
    public class DataDemoDataInitializer : IDataInitializer
    {
        private readonly IUnitOfWork _uow;
        private readonly DbSet<ContactType> _contactType;
        public int Order { get; set; } = 3;

        public DataDemoDataInitializer(IUnitOfWork uow)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(_uow));
            _contactType = _uow.Set<ContactType>();
        }

        /// <summary>
        /// تولید کننده محتوا
        /// </summary>c
        public void InitializeData()
        {
            if (!_contactType.AsNoTracking().Any())
            {
                var path = (AppDomain.CurrentDomain.BaseDirectory + "DataInitVehicles.sql");
                var sql = System.IO.File.ReadAllText(path);
                using (var command = _uow.DbContext.Database.GetDbConnection().CreateCommand())
                {
                    _uow.DbContext.Database.OpenConnection();
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    _uow.DbContext.Database.CloseConnection();
                }
            }
        }
    }
}