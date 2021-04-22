using BusinessLayout.Configuration.Resource;
using FluentValidation;
using System.Resources;

namespace BusinessLayout.Cart.Command.GetCart
{

    public class GetCartCommandValidator : AbstractValidator<GetCartCommand>
    {
        public GetCartCommandValidator(ResourceManager resourceManager)
        {
            RuleFor(p => p.Username).NotEmpty().WithMessage(resourceManager.GetString(ResourceKey.EmptyUsernameAndRedirectToLogin));
        }
    }
}
