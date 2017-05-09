using Gnome.DataAccess;
using MediatR;
using System;
using System.Linq;

namespace Gnome.Services.Account
{
    public class AccountService :
        IRequestHandler<GetAccounts, GetAccountsResponse>,
        IRequestHandler<CreateAccount, CreateAccountResponse>,
        IRequestHandler<RemoveAccount>
    {
        private readonly GnomeDbContext context;

        public AccountService(GnomeDbContext context)
        {
            this.context = context;
        }
        public GetAccountsResponse Handle(GetAccounts message)
        {
            var accounts = context
                .Accounts
                .Where(a => a.OwnerId == message.OwnerId)
                .ToList()
                .Select(a => new Api.Model.Account()
                {
                    Id = a.Id,
                    Name = a.Name
                });

            return new GetAccountsResponse() { Accounts = accounts };
        }

        public CreateAccountResponse Handle(CreateAccount message)
        {
            var account = new DataAccess.Account()
            {
                Id = Guid.NewGuid(),
                Name = message.Name,
                OwnerId = message.OwnerId
            };
            context.Accounts.Add(account);
            context.SaveChanges();

            return new CreateAccountResponse(new Api.Model.Account()
            {
                Id = account.Id,
                Name = account.Name
            });
        }

        public void Handle(RemoveAccount message)
        {
            var account = context.Accounts.Find(message.AccountId);
            context.Accounts.Remove(account);
            context.SaveChanges();
        }
    }
}
