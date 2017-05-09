using MediatR;
using System;

namespace Gnome.Services.Account
{
    public class RemoveAccount : IRequest
    {
        public Guid AccountId { get; private set; }
        public RemoveAccount(Guid accountId)
        {
            this.AccountId = accountId;
        }
    }
}
