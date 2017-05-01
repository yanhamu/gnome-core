using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Gnome.Fio.Downloader.DataAccess
{
    public class FioDownloader
    {
        private readonly string baseUrl;
        private readonly ITransactionsDownloader downloader;

        public FioDownloader(string baseUrl, ITransactionsDownloader downloader)
        {
            this.baseUrl = baseUrl;
            this.downloader = downloader;
        }

        public async Task<Guid> Download(string token, DateTime from, DateTime to)
        {
            var guid = Guid.NewGuid();

            var fromString = from.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            var toString = to.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            var url = $"{baseUrl}/ib_api/rest/periods/{token}/{fromString}/{toString}/transactions.xml";

            await downloader.Download(url, guid);

            return guid;
        }
    }
}
