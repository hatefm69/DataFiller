using Common.Utilities;
using Data.Contracts;
using Entities.Profile;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Services.DataInitializer
{
    public class PhoneNumberTypeDataInitializer : IDataInitializer
    {
        private readonly IUnitOfWork _uow;
        private readonly DbSet<PhoneNumberType> _phoneNumberType;
        public int Order { get; set; } = 2;

        public PhoneNumberTypeDataInitializer(IUnitOfWork uow)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(_uow));
            _phoneNumberType = uow.Set<PhoneNumberType>();
        }

        public void InitializeData()
        {

            if (!_phoneNumberType.AsNoTracking().Any())
            {
                if (!_phoneNumberType.AsNoTracking().Any())
                {
                    _phoneNumberType
                        .AddRange(Enum
                            .GetValues(typeof(PhoneNumberTypeEnum))
                            .OfType<PhoneNumberTypeEnum>()
                            .Select(x => new PhoneNumberType { Id = x, Description = x.ToDisplay() })
                            .ToArray());
                    _uow.SaveChanges();
                }
            }
        }
    }
}