using Gnome.Fio.Downloader.DataAccess;
using Gnome.Fio.Downloader.Model;
using Gnome.Fio.Downloader.Services;
using NSubstitute;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Gnome.Fio.Downloader.Tests.Services
{
    public class FioServiceTests
    {
        [Fact]
        public async Task Should_Send_Transactions()
        {
            var accountId = Guid.NewGuid();
            var documentId = Guid.NewGuid();

            var messaging = Substitute.For<IMessaging>();
            var transactionParser = new TransactionParser();
            var documentHandler = Substitute.For<IDocumentHandler>();

            var service = new FioService(documentHandler, transactionParser, messaging);

            await service.Process(accountId, documentId);

            messaging.Received().Send(Arg.Is<FioTransaction>(p => p.MovementId == 7706841329L), accountId);
            messaging.Received().Send(Arg.Is<FioTransaction>(p => p.MovementId == 13845191074L), accountId);
        }
    }
}
