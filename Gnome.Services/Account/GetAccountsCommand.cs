using MediatR;

namespace Gnome.Services.Account
{
    public class GetAccountsCommand : IRequest<GetAccountsResponse>
    {
        public string OwnerId { get; private set; }

        public GetAccountsCommand(string userId)
        {
            this.OwnerId = userId;
        }
    }
}