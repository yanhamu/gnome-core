using System.Collections.Generic;

namespace Gnome.Services.Transaction
{
    public class GetTransactionResponse
    {
        public List<Api.Model.FioTransaction> Transactions { get; private set; }

        public GetTransactionResponse(List<Api.Model.FioTransaction> transactions)
        {
            this.Transactions = transactions;
        }
    }
}