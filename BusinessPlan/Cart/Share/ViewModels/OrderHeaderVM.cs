using BusinessLayout.Share;
using Entities.Order;
using System;
using System.Collections.Generic;
using ViewModels.AutoMapepr;

namespace BusinessLayout.Cart.Share.ViewModels
{
    public class OrderHeaderVm : BaseNotIdDto<OrderHeaderVm, OrderHeader>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// فهرست آیتم های موجود در فاکتور
        /// </summary>
        public ICollection<OrderDetailVm> OrderDetails { get; set; }
        public OrderStatusEnum OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public ICollection<DeliveryBillVM> Shippings { get; set; }

        /// <summary>
        /// شناسه پروفایل
        /// </summary>
        public int ProfileId { get; set; }

        /// <summary>
        /// شناسه پرداخت
        /// </summary>
        public string PaymentDocAuthority { get; set; }

        /// <summary>
        /// کد پیگیری
        /// </summary>
        public string ReferenceId { get; set; }
        public string DeliveryProvince { get; set; }
        public string DeliveryCity { get; set; }

        /// <summary>
        /// آدرس تحویل
        /// </summary>
        public string DeliveryAddress { get; set; }
        public DateTime CreateDm { get; set; }
        public List<OrderDetailVm> ConflictsQty { get; set; }
        public List<OrderDetailVm> ConflictsPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public decimal SumPrice { get; set; }
    }
    public class OrderHeaderDto : BaseNotIdDto<OrderHeaderDto, OrderHeader>
    {
        /// <summary>
        /// فهرست آیتم های موجود در فاکتور
        /// </summary>
        public ICollection<OrderDetailDto> OrderDetails { get; set; }

        /// <summary>
        /// شناسه پروفایل
        /// </summary>
        public int ProfileId { get; set; }

        /// <summary>
        /// شناسه پرداخت
        /// </summary>
        public string Authority { get; set; }

        /// <summary>
        /// کد پیگیری
        /// </summary>
        public string ReferenceId { get; set; }
        public string DeliveryProvince { get; set; }
        public string DeliveryCity { get; set; }

        /// <summary>
        /// آدرس تحویل
        /// </summary>
        public string DeliveryAddress { get; set; }
    }
}