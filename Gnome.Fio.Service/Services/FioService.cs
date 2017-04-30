using Gnome.Fio.Service.DataAccess;
using Gnome.Fio.Service.Model;
using Gnome.Fio.Service.Services;
using System;
using System.Threading.Tasks;

namespace Gnome.Fio.Downloader.Services
{
    public class FioService : IFioService
    {
        private readonly IDocumentHandler documentHandler;
        private readonly ITransactionParser transactionParser;
        private readonly IMessaging messaging;

        public FioService(
            IDocumentHandler documentHandler,
            ITransactionParser transactionParser,
            IMessaging messaging)
        {
            this.documentHandler = documentHandler;
            this.transactionParser = transactionParser;
            this.messaging = messaging;
        }

        public async Task Process(Guid accountId, Guid documentId)
        {
            using (var document = await documentHandler.Load(documentId))
            {
                var result = transactionParser.Parse(document);

                foreach (var transaction in result)
                {
                    messaging.Send(transaction, accountId);
                }
            }
        }
    }
}
