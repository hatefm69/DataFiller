using Common.Utilities;
using Data.Contracts;
using Entities.Sale.Role;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DataInitializer
{
    public class SaleRoleTypeDataInitializer : IDataInitializer
    {
        private IUnitOfWork _uow;
        private DbSet<SaleRoleType> _saleRoleType;

        public SaleRoleTypeDataInitializer(IUnitOfWork uow)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(_uow));
            _saleRoleType = _uow.Set<SaleRoleType>();
        }

        public int Order { get; set; } = 0;

        public void InitializeData()
        {
            if (!_saleRoleType.Any())
            {
                _saleRoleType
                   .AddRange(Enum
                       .GetValues(typeof(SaleRoleTypeEnum))
                       .OfType<SaleRoleTypeEnum>()
                       .Select(x => new SaleRoleType { Id = x, Value = x.ToDisplay() }).ToArray());
                _uow.SaveChanges();
            }
        }
    }
}
