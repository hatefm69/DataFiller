using BusinessLayout.Cart.Share.Dto;
using BusinessLayout.Configuration.Commands;
using BusinessLayout.Share.Cart;
using Services;

namespace BusinessLayout.Cart.Command.AddCart
{
    public class AddCartHeaderCommand : CommandBase<ServiceResult<CartHeaderVM>>
    {
        public AddCartHeaderCommand(CartHeaderDto model, string username)
        {
            Model = model;
            Username = username;
        }

        public CartHeaderDto Model { get; }
        public string Username { get; }
    }
}