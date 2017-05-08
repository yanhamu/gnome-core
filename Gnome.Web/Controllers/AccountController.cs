using Gnome.DataAccess;
using Gnome.Services;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Gnome.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly GnomeDbContext context;
        private readonly IMediator mediator;

        public AccountController(GnomeDbContext context, IMediator mediator)
        {
            this.context = context;
            this.mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var count = context.Accounts.ToList().Count;

            var result = await mediator.Send(new RandomCommand());

            return new OkObjectResult(new { data = count.ToString() + " random data " + result });
        }
    }
}