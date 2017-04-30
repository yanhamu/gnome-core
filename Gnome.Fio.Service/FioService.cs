using Gnome.Fio.Service.DataAccess;
using Gnome.Fio.Service.Model;
using Gnome.Fio.Service.Services;
using System.Threading.Tasks;

namespace Gnome.Fio.Service
{
    public class FioService
    {
        private readonly FioTransactionFactory transactionFactory;
        private readonly FioDownloader fioDownloader;
        private readonly IDocumentHandler documentHandler;
        private readonly ITransactionParser transactionParser;
        private readonly IMessaging messaging;

        public FioService(
            FioTransactionFactory transactionFactory,
            FioDownloader fioDownloader,
            IDocumentHandler documentHandler,
            ITransactionParser transactionParser,
            IMessaging messaging)
        {
            this.transactionFactory = transactionFactory;
            this.fioDownloader = fioDownloader;
            this.documentHandler = documentHandler;
            this.transactionParser = transactionParser;
            this.messaging = messaging;
        }

        public async Task Synchronize(TransactionSyncCommand command)
        {
            var documentId = await fioDownloader.Download(command.Token, command.From, command.To);
            using (var document = await documentHandler.Load(documentId))
            {
                var result = transactionParser.Parse(document);

                foreach (var transaction in result.TransactionList)
                {
                    var fioTransaction = transactionFactory.Create(transaction, command.AccountId);
                    messaging.Send(fioTransaction);
                }

                var downloadStatus = DownloadStatus.CreateOk(command.AccountId, documentId);
                messaging.Send(downloadStatus);
            }
        }
    }
}
