using Gnome.Fio.Service.Client;
using Gnome.Fio.Service.Model;
using System.Threading.Tasks;

namespace Gnome.Fio.Service
{
    public class FioService
    {
        private readonly IFioClient fioClient;
        private readonly IGnomeClient gnomeClient;
        private readonly FioTransactionFactory transactionFactory;

        public FioService(
            IFioClient fioClient,
            IGnomeClient gnomeClient,
            FioTransactionFactory transactionFactory)
        {
            this.fioClient = fioClient;
            this.gnomeClient = gnomeClient;
            this.transactionFactory = transactionFactory;
        }

        public async Task Synchronize(TransactionSyncCommand command)
        {
            var result = await fioClient.GetAccountStatementAsync(command.Token, command.From, command.To);

            foreach (var transaction in result.TransactionList)
            {
                var fioTransaction = transactionFactory.Create(transaction);
                gnomeClient.Send(fioTransaction, command.AccountId);
            }
        }
    }
}
