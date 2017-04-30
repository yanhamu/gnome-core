using Gnome.Fio.Service.Model;

namespace Gnome.Fio.Service.DataAccess
{
    public interface IMessaging
    {
        void Send(FioTransaction fioTransaction);
        void Send(DownloadStatus downloadStatus);
    }
}
