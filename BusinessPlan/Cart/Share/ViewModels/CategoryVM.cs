using BusinessLayout.Share;
using System.Collections.Generic;
using ViewModels.AutoMapepr;

namespace BusinessLayout.Cart.Share.ViewModels
{
    public class CategoryWithParentVm : BaseDto<CategoryWithParentVm, Entities.Product.Category>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public CategoryWithParentVm Parent { get; set; }
    }

    public class CategoryWithProductsVm : BaseDto<CategoryWithProductsVm, Entities.Product.Category>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public CategoryWithParentVm Parent { get; set; }
        public IEnumerable<PartVm> Parts { get; set; }
    }
}