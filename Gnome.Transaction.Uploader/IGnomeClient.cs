using Gnome.Transactions.Common;
using System;
using System.Threading.Tasks;

namespace Gnome.Transactions.Uploader
{
    public interface IGnomeClient
    {
        Task SendAsync(FioTransaction transaction, Guid accountId);
    }
}
