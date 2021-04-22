using BusinessLayout.Cart.Share;
using BusinessLayout.Configuration.Queries;
using BusinessLayout.Share.Cart;
using Common.Utilities;
using Dapper;
using Data;
using Entities.DapperEntities;
using Microsoft.Extensions.Logging;
using Services;
using Services.Cart;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLayout.Cart.Query.GetCart
{
    public class GetCartQueryHandler : IQueryHandler<GetCartQuery, ServiceResult<CartHeaderVM>>
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;
        private readonly ILogger<GetCartQueryHandler> _logger;
        private readonly IBuildCard _buildCard;
        private readonly ICartService _cartService;

        public GetCartQueryHandler(IBuildCard buildCard, ILogger<GetCartQueryHandler> logger, ICartService cartService)
        {

            _logger = logger;

            _buildCard = buildCard;
        }

        public async Task<ServiceResult<CartHeaderVM>> Handle(GetCartQuery request, CancellationToken cancellationToken)
        {
            Log.LogMethod(_logger, MethodBase.GetCurrentMethod(), null, request, cancellationToken);
            var result = await _buildCard.Get(request);
            if (result.IsSuccess)
            {
                SetImageFirstCartDetail(result);
                SetImageFirstConfilctsPrice(result);
                SetImageFirstConfilctsQty(result);
            }

            return result;
        }

        private static void SetImageFirstConfilctsQty(ServiceResult<CartHeaderVM> result)
        {
            foreach (var item in result.Data.ConflictsQty)
            {
                item.Product.Part.ImagePath = item.Product.Images.FirstOrDefault(x => x.Type == Entities.Product.ImageType.Main)?.Path ?? string.Empty;
            }
        }

        private static void SetImageFirstConfilctsPrice(ServiceResult<CartHeaderVM> result)
        {
            foreach (var item in result.Data.ConflictsPrice)
            {
                item.Product.Part.ImagePath = item.Product.Images.FirstOrDefault(x => x.Type == Entities.Product.ImageType.Main)?.Path ?? string.Empty;
            }
        }

        private static void SetImageFirstCartDetail(ServiceResult<CartHeaderVM> result)
        {
            foreach (var item in result.Data.CartDetails)
            {
                item.Product.Part.ImagePath = item.Product.Images.FirstOrDefault(x => x.Type == Entities.Product.ImageType.Main)?.Path ?? string.Empty;
            }
        }
    }
}