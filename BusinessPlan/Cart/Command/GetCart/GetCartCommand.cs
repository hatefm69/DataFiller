using BusinessLayout.Configuration.Commands;
using BusinessLayout.Share.Cart;
using Services;

namespace BusinessLayout.Cart.Command.GetCart
{
    public class GetCartCommand : CommandBase<ServiceResult<CartHeaderVM>>
    {
        public GetCartCommand(string username)
        {
            Username = username;
        }
        public string Username { get; }
    }
}
