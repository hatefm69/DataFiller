using Common.Utilities;
using Data.Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Services.DataInitializer
{
    /// <summary>
    /// کلاس برای تولید محتوای قرارداد 
    /// </summary>
    public class ContactTypeDataInitializer : IDataInitializer
    {
        private readonly IUnitOfWork _uow;
        private readonly DbSet<ContactType> _contactType;
        public int Order { get; set; } = 0;

        public ContactTypeDataInitializer(IUnitOfWork uow)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(_uow));
            _contactType = _uow.Set<ContactType>();
        }

        /// <summary>
        /// تولید کننده محتوا
        /// </summary>
        public void InitializeData()
        {
            if (!_contactType.AsNoTracking().Any())
            {
                _contactType
                    .AddRange(Enum
                        .GetValues(typeof(ContactTypeEnum))
                        .OfType<ContactTypeEnum>()
                        .Select(x => new ContactType { Id = x, Value = x.ToDisplay() }).ToArray());
                _uow.SaveChanges();
            }
        }
    }
}