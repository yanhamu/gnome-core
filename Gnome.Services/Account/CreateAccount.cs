using MediatR;

namespace Gnome.Services.Account
{
    public class CreateAccount : IRequest<CreateAccountResponse>
    {
        public string Name { get; set; }
        public string OwnerId { get; set; }
    }
}
