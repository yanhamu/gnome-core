using MediatR;
using System;

namespace Gnome.Services.Transaction
{
    public class GetTransactions : IRequest<GetTransactionResponse>
    {
        public Guid AccountId { get; private set; }

        public GetTransactions(Guid accountId)
        {
            this.AccountId = accountId;
        }
    }
}