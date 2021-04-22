using BusinessLayout.Cart.Share.Dto;
using Common.Resource;
using FluentValidation;
using System.Resources;

namespace BusinessLayout.Cart.Command.AddCart
{
    public class CartDetailDtoValidator : AbstractValidator<CartDetailDto>
    {
        public CartDetailDtoValidator(ResourceManager resourceManager)
        {
            RuleFor(x => x.Qty)
                .GreaterThan(0)
                .WithMessage(resourceManager.GetString(ResourceKey.ZeroProductRequested));
        }
    }
}