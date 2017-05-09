using Gnome.Transactions.Common;
using System;
using System.Threading.Tasks;

namespace Gnome.Transactions.Uploader
{
    public class GnomeClient : IGnomeClient
    {
        public Task SendAsync(FioTransaction transaction, Guid accountId)
        {
            //var token = GetToken(username, password);
            //SendTransaction(transaction, accountId, token)

            throw new NotImplementedException();
            //TODO implement
        }
    }
}
