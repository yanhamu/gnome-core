using Gnome.Services.Account;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
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
            var result = await mediator.Send(new GetAccounts(userId));

            return new OkObjectResult(result);
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody]CreateAccount createAccount)
        {
            var userId = HttpContext.User.FindFirst("user_id").Value;

            createAccount.OwnerId = userId;
            var result = await mediator.Send(createAccount);

            return new OkObjectResult(result);
        }

        [HttpDelete("{accountId}")]
        public async Task<IActionResult> Remove(Guid accountId)
        {
            await mediator.Send(new RemoveAccount(accountId));
            return new NoContentResult();
        }
    }
}