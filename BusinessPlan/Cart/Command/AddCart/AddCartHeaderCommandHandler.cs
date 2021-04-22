//using BusinessLayout.Configuration.Commands;
//using BusinessLayout.Share.Cart;
//using Common.Utilities;
//using Microsoft.Extensions.Logging;
//using Services;
//using System.Reflection;
//using System.Threading;
//using System.Threading.Tasks;

//namespace BusinessLayout.Cart.Command.AddCart
//{
//    public class AddCartHeaderCommandHandler : ICommandHandler<AddCartHeaderCommand, ServiceResult<CartHeaderVM>>
//    {

//        private readonly ILogger<AddCartHeaderCommandHandler> _logger;
//        private readonly IBuildCard _buildCard;

//        public AddCartHeaderCommandHandler(ILogger<AddCartHeaderCommandHandler> logger, IBuildCard buildCard)
//        {
//            _logger = logger;
//            _buildCard = buildCard;
//        }

//        public async Task<ServiceResult<CartHeaderVM>> Handle(AddCartHeaderCommand request, CancellationToken cancellationToken)
//        {
//            Log.LogMethod(_logger, MethodBase.GetCurrentMethod(), null, request, cancellationToken);

//            return await _buildCard.Update(new AddCartHeader.AddCartHeaderCommand(request.Model, request.Username));
//        }

//    }
//}