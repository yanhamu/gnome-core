using System;
using System.IO;
using System.Threading.Tasks;

namespace Gnome.Fio.Service.DataAccess
{
    public class FileDocumentHandler : IDocumentHandler
    {
        private readonly string storagePath;

        public FileDocumentHandler(string storagePath)
        {
            this.storagePath = storagePath;
        }

        public async Task<Stream> Load(Guid documentId)
        {
            var filePath = GetFilePath(documentId);
            using (var file = File.OpenRead(filePath))
            {
                return await Task.FromResult(file);
            }
        }

        public async Task Save(Guid documentId, Stream stream)
        {
            string filePath = GetFilePath(documentId);

            using (var file = File.OpenWrite(filePath))
            {
                await stream.CopyToAsync(file);
            }
        }

        private string GetFilePath(Guid documentId)
        {
            return $"{storagePath}\\{documentId.ToString()}.xml";
        }
    }
}
