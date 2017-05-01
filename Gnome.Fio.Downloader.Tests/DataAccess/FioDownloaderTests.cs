using Gnome.Fio.Downloader.DataAccess;
using NSubstitute;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Gnome.Fio.Downloader.Tests.DataAccess
{
    public class FioDownloaderTests
    {
        [Fact]
        public async Task Should_Call_Downloader_With_Valid_Url()
        {
            var downloader = Substitute.For<ITransactionsDownloader>();
            var fioDownloader = new FioDownloader("http://fio.api.cz", downloader);

            var from = new DateTime(2017, 01, 01, 10, 55, 02);
            var to = new DateTime(2017, 01, 05, 12, 54, 01);

            await fioDownloader.Download("token", from, to);
            await downloader.Received().Download("http://fio.api.cz/ib_api/rest/periods/token/2017-01-01/2017-01-05/transactions.xml", Arg.Any<Guid>());
        }
    }
}
