using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebFramework.Filters;

namespace WebFramework.Api
{
    [ApiController]
    [ApiResultFilter]
    //[Authorize]
    [Route("api/v{version:apiVersion}/[controller]")]// api/v1/[controller]
    [Authorize("Authorization")]
    public class BaseController : Controller
    {
        //public UserRepository UserRepository { get; set; } => property injection
        protected bool UserIsAutheticated => HttpContext.User.Identity.IsAuthenticated;
        protected string Username => HttpContext.User?.Identity?.Name;
    }
}