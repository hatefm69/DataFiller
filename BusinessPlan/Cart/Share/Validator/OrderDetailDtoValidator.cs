using BusinessLayout.Cart.Share.ViewModels;
using Common.Resource;
using FluentValidation;
using Services.Product;
using System.Resources;

namespace BusinessLayout.Cart.Share.Validator
{
    public class OrderDetailDtoValidator : AbstractValidator<OrderDetailDto>
    {
        public OrderDetailDtoValidator(ResourceManager resourceManager, IProductService productService)
        {
            RuleFor(c => c.ProductId)
                .NotEmpty()
                .WithMessage(resourceManager.GetString(ResourceKey.EmptyProductId));

            RuleFor(c => c.ProductId)
                .MustAsync(async (u, cancellation) => (await productService.IsProductExists(u)).IsSuccess)
                .WithMessage(resourceManager.GetString(ResourceKey.NotFoundProduct));
        }
    }
}
