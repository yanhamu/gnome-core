using MediatR;
using System;

namespace Gnome.Services.Transaction
{
    public class CreateFioTransaction : IRequest<Api.Model.FioTransaction>
    {
        public Guid AccountId { get; set; }
        public Api.Model.FioTransaction Transaction { get; set; }

        public CreateFioTransaction(Guid accountId, Api.Model.FioTransaction transaction)
        {
            this.AccountId = accountId;
            this.Transaction = transaction;
        }
    }
}
