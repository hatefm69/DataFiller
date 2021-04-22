using Common.Resource;
using FluentValidation;
using System.Resources;

namespace BusinessLayout.Cart.Command.AddCart
{
    public class AddCartHeaderCommandValidator : AbstractValidator<AddCartHeaderCommand>
    {
        public AddCartHeaderCommandValidator(ResourceManager resourceManager)
        {
            RuleFor(c => c.Username)
                .NotEmpty()
                .WithMessage(resourceManager.GetString(ResourceKey.EmptyUsername));

            RuleFor(x => x.Model)
                .NotEmpty()
                .WithMessage(resourceManager.GetString(ResourceKey.EmptyCartHeader));

            RuleForEach(c => c.Model.CartDetails)
                .SetValidator(new CartDetailDtoValidator(resourceManager));
        }
    }
}