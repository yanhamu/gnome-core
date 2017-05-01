using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gnome.Fio.Downloader.DataAccess
{
    public class TransactionsDownloader : ITransactionsDownloader
    {
        private readonly IDocumentHandler documentHandler;

        public TransactionsDownloader(IDocumentHandler documentHandler)
        {
            this.documentHandler = documentHandler;
        }

        public async Task Download(string uri, Guid documentId)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStreamAsync(uri);
                await documentHandler.Save(documentId, response);
            }
        }
    }
}
