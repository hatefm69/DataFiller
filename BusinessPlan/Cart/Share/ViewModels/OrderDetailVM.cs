using AutoMapper;
using BusinessLayout.Share;
using Entities.Order;
using ViewModels.AutoMapepr;

namespace BusinessLayout.Cart.Share.ViewModels
{
    public class OrderDetailVm : BaseNotIdDto<OrderDetailVm, OrderDetail>
    {
        ///// <summary>
        ///// شناسه فاکتور
        ///// </summary>
        //public int OrderHeaderId { get; set; }

        /// <summary>
        /// مدل داده فاکتور
        /// </summary>
        //public OrderHeaderVm OrderHeader { get; set; }

        /// <summary>
        /// شناسه محصول
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// مدل داده محصول
        /// </summary>
        public ProductVm Product { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        public double Qty { get; set; }

        /// <summary>
        /// قیمت واحد
        /// </summary>
        public decimal Price { get; set; }
        public double OldQty { get; set; }
        public decimal OldUnitPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal FinalPrice { get;  set; }
        public decimal SumPrice { get; set; }
        public override void CustomMappings(IMappingExpression<OrderDetail, OrderDetailVm> mapping)
        {
            mapping.ForMember(x => x.Qty, y => y.MapFrom(c => c.Quantity));
    
        }
    }
   

    public class OrderDetailDto : BaseNotIdDto<OrderDetailDto, OrderDetail>
    {
        ///// <summary>
        ///// شناسه فاکتور
        ///// </summary>
        //public int OrderHeaderId { get; set; }

        ///// <summary>
        ///// مدل داده فاکتور
        ///// </summary>
        //public OrderHeaderDto OrderHeader { get; set; }

        /// <summary>
        /// شناسه محصول
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// مدل داده محصول
        /// </summary>
        //public Product.Product product { get; set; }
        /// <summary>
        /// تعداد
        /// </summary>
        public double Qty { get; set; }

        ///// <summary>
        ///// قیمت واحد
        ///// </summary>
        //public decimal Price { get; set; }
        public int RowNumber { get; set; }
        public override void CustomMappings(IMappingExpression<OrderDetail, OrderDetailDto> mapping)
        {
            mapping.ForMember(x => x.Qty, m => m.MapFrom(c => c.Quantity));
        }
        public override void CustomMappingsReverse(IMappingExpression<OrderDetailDto, OrderDetail> mapping)
        {
            mapping.ForMember(x => x.Quantity, m => m.MapFrom(c => c.Qty));
        }
    }
}