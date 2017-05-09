using MediatR;

namespace Gnome.Services.Account
{
    public class GetAccounts : IRequest<GetAccountsResponse>
    {
        public string OwnerId { get; private set; }

        public GetAccounts(string userId)
        {
            this.OwnerId = userId;
        }
    }
}