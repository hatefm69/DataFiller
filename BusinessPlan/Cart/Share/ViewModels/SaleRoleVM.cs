using BusinessLayout.Share;
using Entities.Sale.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.AutoMapepr;

namespace BusinessLayout.Cart.Share.ViewModels
{
    public class SaleRoleVM : BaseDto<SaleRoleVM, SaleRole>
    {
        public Guid GroupId { get; set; }
        public int MultipleQTY { get; set; }
        public SaleRoleTypeVM SaleRoleType { get; set; }
        public ProductVm Product { get; set; }
    }
}
