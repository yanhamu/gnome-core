using Gnome.Services;
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
            var result = await mediator.Send(new RandomCommand());
            var user = this.HttpContext.User;

            var claim = user.FindFirst("user_id");
            var userId = claim.Value;

            return new OkObjectResult($"random data {result} + user id:{userId}");
        }
    }
}