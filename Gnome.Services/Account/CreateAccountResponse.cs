namespace Gnome.Services.Account
{
    public class CreateAccountResponse
    {
        public Api.Model.Account Account { get; private set; }

        public CreateAccountResponse(Api.Model.Account account)
        {
            this.Account = account;
        }
    }
}