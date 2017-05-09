using Gnome.Services.Transaction;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Gnome.Web.Controllers
{
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {
        private readonly IMediator mediator;

        public TransactionController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("/api/account/{accountId:guid}/transactions")]
        public async Task<IActionResult> GetTransactions(Guid accountId)
        {
            var result = await mediator.Send(new GetTransactionsCommand(accountId));
            return new OkObjectResult(result);
        }
    }
}
