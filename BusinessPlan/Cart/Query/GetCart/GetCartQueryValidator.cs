using Common.Resource;
using FluentValidation;
using Services.Profile;
using System.Resources;

namespace BusinessLayout.Cart.Query.GetCart
{
    public class GetCartQueryValidator : AbstractValidator<GetCartQuery>
    {
        public GetCartQueryValidator(ResourceManager resourceManager, IProfileService profileService)
        {
            RuleFor(c => c.Username)
                .NotEmpty()
                .WithMessage(resourceManager.GetString(ResourceKey.EmptyUsername));

            RuleFor(c => c.Username)
                .MustAsync(async (u, cancellation) => (await profileService.ProfileExists(u)).IsSuccess)
                .WithMessage(resourceManager.GetString(ResourceKey.NotFoundUser));
        }
    }
}