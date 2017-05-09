using MediatR;
using System;

namespace Gnome.Services.Account
{
    public class RemoveAccountCommand : IRequest
    {
        public Guid AccountId { get; private set; }
        public RemoveAccountCommand(Guid accountId)
        {
            this.AccountId = accountId;
        }
    }
}
