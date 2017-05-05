using System;

namespace Gnome.Transactions.Common
{
    public class TransactionMessage<T>
    {
        public Guid AccountId { get; private set; }
        public T Data { get; private set; }

        public TransactionMessage(T data, Guid accountId)
        {
            this.AccountId = accountId;
            this.Data = data;
        }
    }
}