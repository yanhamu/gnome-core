using Gnome.Fio.Service.Model;

namespace Gnome.Fio.Service.Client
{
    public interface IGnomeClient
    {
        void Send(FioTransaction fioTransaction, int accountId);
    }
}
