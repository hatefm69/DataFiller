using BusinessLayout.Share;
using System.Collections.Generic;
using ViewModels.AutoMapepr;

namespace BusinessLayout.Cart.Share.ViewModels
{
    public class CategoryWithPartsVm : BaseDto<CategoryWithPartsVm, Entities.Product.Category>
    {
        public string Name { get; set; }
        public ICollection<PartVm> Parts { get; set; }
    }
}