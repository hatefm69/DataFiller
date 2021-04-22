using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLayout.Configuration.Commands;
using BusinessLayout.Configuration.Queries;
using BusinessLayout.Share.Cart;
using MediatR;
using Services;
using Services.Cart;

namespace BusinessLayout.Cart.Command.GetCart
{
    public class GetCartCommandHandler : ICommandHandler<GetCartCommand, ServiceResult<CartHeaderVM>>
    {
        private ICartService _cartService;

        public GetCartCommandHandler(ICartService cartService)
        {
            _cartService = cartService;
        }

        public async Task<ServiceResult<CartHeaderVM>> Handle(GetCartCommand request, CancellationToken cancellationToken)
        {
            var result = await _cartService.GetCart(request.Username);

            if (result.IsSuccess)
                return CartHeaderVM.FromEntity(result.Data);

            return new ServiceResult<CartHeaderVM>(false, Common.ApiResultStatusCode.NotFound, null);
        }
    }
}