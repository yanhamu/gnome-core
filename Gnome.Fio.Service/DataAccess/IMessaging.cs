using Gnome.Fio.Service.Model;
using System;

namespace Gnome.Fio.Service.DataAccess
{
    public interface IMessaging
    {
        void Send(DownloadStatus downloadStatus);
        void Send(FioTransaction transaction, Guid accountId);
    }
}
