using MediatR;

namespace Gnome.Services.Account
{
    public class CreateAccountCommand : IRequest<CreateAccountResponse>
    {
        public string Name { get; set; }
        public string OwnerId { get; set; }
    }
}
