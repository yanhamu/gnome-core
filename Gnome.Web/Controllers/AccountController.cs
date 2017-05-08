using Gnome.Services.Account;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Gnome.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IMediator mediator;

        public AccountController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var userId = HttpContext.User.FindFirst("user_id").Value;
            var result = await mediator.Send(new GetAccountsCommand(userId));

            return new OkObjectResult(result);
        }
    }
}