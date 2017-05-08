using Gnome.DataAccess;
using MediatR;
using System;
using System.Linq;

namespace Gnome.Services.Account
{
    public class AccountService : 
        IRequestHandler<GetAccountsCommand, GetAccountsResponse>,
        IRequestHandler<CreateAccountCommand, CreateAccountResponse>
    {
        private readonly GnomeDbContext context;

        public AccountService(DataAccess.GnomeDbContext context)
        {
            this.context = context;
        }
        public GetAccountsResponse Handle(GetAccountsCommand message)
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

        public CreateAccountResponse Handle(CreateAccountCommand message)
        {
            var account = new Gnome.DataAccess.Account()
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
    }
}
