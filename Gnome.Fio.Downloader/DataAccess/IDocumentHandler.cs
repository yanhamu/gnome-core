using System;
using System.IO;
using System.Threading.Tasks;

namespace Gnome.Fio.Downloader.DataAccess
{
    public interface IDocumentHandler
    {
        Task<Stream> Load(Guid documentId);
        Task Save(Guid documentId, Stream stream);
    }
}
