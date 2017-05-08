using System.Collections.Generic;

namespace Gnome.Services.Account
{
    public class GetAccountsResponse
    {
        public IEnumerable<Gnome.Api.Model.Account> Accounts { get; set; }
    }
}
