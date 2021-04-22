using Data.Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;

namespace Services.DataInitializer
{
    public class DataSyncDataInitializer : IDataInitializer
    {
        private readonly IUnitOfWork _uow;
        private readonly DbSet<ContactType> _contactType;
        public int Order { get; set; } = 4;

        public DataSyncDataInitializer(IUnitOfWork uow)
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
                using (var command = _uow.DbContext.Database.GetDbConnection().CreateCommand())
                {
                    _uow.DbContext.Database.OpenConnection();
                    command.CommandText = DatabaseStoreProcedure.SyncAllData;
                    command.CommandType = CommandType.StoredProcedure;

                    command.ExecuteNonQuery();
                    _uow.DbContext.Database.CloseConnection();
                }
            }
        }
    }
}