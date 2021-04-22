using Entities.Order;
using System.Collections.Generic;
using ViewModels.AutoMapepr;

namespace BusinessLayout.Cart.Share.Dto
{
    public class CartHeaderDto : BaseNotIdDto<CartHeaderDto, CartHeader>
    {
        public ICollection<CartDetailDto> CartDetails { get; set; }
    }

    public class CartDetailDto : BaseNotIdDto<CartDetailDto, CartDetail>
    {
        public int? ProductId { get; set; }
        public double? Qty { get; set; }
        public int RowNumber { get; set; } = 1000;
        public string Title { get; set; }
        public string Description { get; set; }
    }
}