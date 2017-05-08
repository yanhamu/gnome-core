using Gnome.DataAccess;
using MediatR;
using System.Linq;

namespace Gnome.Services.Account
{
    public class AccountService : IRequestHandler<GetAccountsCommand, GetAccountsResponse>
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
    }
}
