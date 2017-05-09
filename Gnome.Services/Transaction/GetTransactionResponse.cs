using System.Collections.Generic;

namespace Gnome.Services.Transaction
{
    public class GetTransactionResponse
    {
        public List<Api.Model.Transaction> Transactions { get; private set; }

        public GetTransactionResponse(List<Api.Model.Transaction> transactions)
        {
            this.Transactions = transactions;
        }
    }
}