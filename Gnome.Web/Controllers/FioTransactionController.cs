using Gnome.Services.Transaction;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Gnome.Web.Controllers
{
    [Route("api/account/{accountId:guid}/transactions")]
    public class FioTransactionController : Controller
    {
        private readonly IMediator mediator;

        public FioTransactionController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet()]
        public async Task<IActionResult> GetTransactions(Guid accountId)
        {
            var result = await mediator.Send(new GetTransactions(accountId));
            return new OkObjectResult(result);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateTransaction(Guid accountId, [FromBody]Api.Model.FioTransaction fioTransaction)
        {
            var result = await mediator.Send(new CreateFioTransaction(accountId, fioTransaction));
            return new OkObjectResult(result);
        }
    }
}
