using Gnome.Fio.Service.Model;

namespace Gnome.Fio.Service.Client
{
    public interface IFioService
    {
        void Sync(TransactionSyncCommand command);
    }
}
