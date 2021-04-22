using Common.Utilities;
using Data.Contracts;
using Entities.Pricing;
using Entities.Profile;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Services.DataInitializer
{
    public class ProfileTypeProfitDataInitializer : IDataInitializer
    {
        private readonly IUnitOfWork _uow;
        private readonly DbSet<ProfileTypeProfit> _profileTypeProfits;
        public int Order { get; set; } = 5;

        public ProfileTypeProfitDataInitializer(IUnitOfWork uow)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(_uow));
            _profileTypeProfits = uow.Set<ProfileTypeProfit>();
        }

        public void InitializeData()
        {
            if (!_profileTypeProfits.AsNoTracking().Any())
            {
                if (!_profileTypeProfits.AsNoTracking().Any())
                {
                    _profileTypeProfits
                        .AddRange(Enum
                            .GetValues(typeof(ProfileTypeEnum))
                            .OfType<ProfileTypeEnum>()
                            .Select(t => new ProfileTypeProfit
                            {
                                Id = (int)t,
                                CreateDm = DateTime.Now,
                                CreateDs = DateTime.Now.ToPersian(),
                                ProfileTypeId = t,
                                ProfileTypeName = t.ToDisplay(),
                                DefaultProfitPercent = CalculateDefaultPercent((int)t)
                            })
                            .ToArray());
                    _uow.SaveChanges();
                }
            }
        }

        private double CalculateDefaultPercent(int profileTypeId)
        {
            switch (profileTypeId)
            {
                case 1:
                    return 0d;
                case 2:
                    return 5d;
                case 3:
                    return 10d;
                case 4:
                    return 5d;
                default:
                    return 0d;
            }
        }
    }
}