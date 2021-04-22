using BusinessLayout.Configuration.Queries;
using BusinessLayout.Share.Cart;
using Services;

namespace BusinessLayout.Cart.Query.GetCart
{
    public class GetCartQuery : IQuery<ServiceResult<CartHeaderVM>>
    {
        public GetCartQuery(string username)
        {
            Username = username;
        }

        public string Username { get; }
    }
}