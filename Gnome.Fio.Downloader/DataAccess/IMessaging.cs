using Gnome.Fio.Downloader.Model;
using System;

namespace Gnome.Fio.Downloader.DataAccess
{
    public interface IMessaging
    {
        void Send(DownloadStatus downloadStatus);
        void Send(FioTransaction transaction, Guid accountId);
    }
}
