using MediatR;
using System;

namespace Gnome.Services.Transaction
{
    public class GetTransactionsCommand : IRequest<GetTransactionResponse>
    {
        public Guid AccountId { get; private set; }

        public GetTransactionsCommand(Guid accountId)
        {
            this.AccountId = accountId;
        }
    }
}
