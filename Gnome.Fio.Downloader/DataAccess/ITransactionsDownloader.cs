using System;
using System.Threading.Tasks;

namespace Gnome.Fio.Downloader.DataAccess
{
    public interface ITransactionsDownloader
    {
        Task Download(string uri, Guid documentId);
    }
}