using Common.Utilities;
using Data.Contracts;
using Entities.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Services.DataInitializer
{
    public class OrderStatusDataInitializer : IDataInitializer
    {
        private readonly IUnitOfWork _uow;
        private readonly DbSet<OrderStatus> _orderStatus;
        public int Order { get; set; } = 1;

        public OrderStatusDataInitializer(IUnitOfWork uow)
        {
            _uow = uow ?? throw new ArgumentNullException(nameof(_uow));
            _orderStatus = uow.Set<OrderStatus>();
        }

        public void InitializeData()
        {
            if (!_orderStatus.AsNoTracking().Any())
            {
                if (!_orderStatus.AsNoTracking().Any())
                {
                    _orderStatus
                        .AddRange(Enum
                            .GetValues(typeof(OrderStatusEnum))
                            .OfType<OrderStatusEnum>()
                            .Select(x => new OrderStatus { Id = x, Description = x.ToDisplay() })
                            .ToArray());
                    _uow.SaveChanges();
                }
            }
        }
    }
}