using Entities.Sale.Role;
using ViewModels.AutoMapepr;

namespace BusinessLayout.Cart.Share.ViewModels
{
    public class SaleRoleTypeVM : BaseDto<SaleRoleTypeVM, SaleRoleType, SaleRoleTypeEnum>
    {
        public string Value { get; set; }
    }
}
