using System;
using System.Threading.Tasks;

namespace Gnome.Fio.Downloader.Services
{
    public interface IFioService
    {
        Task Process(Guid accountId, Guid documentId);
    }
}
