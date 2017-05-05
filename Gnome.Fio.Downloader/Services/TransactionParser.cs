using Gnome.Transactions.Common;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Gnome.Fio.Downloader.Services
{
    public class TransactionParser : ITransactionParser
    {
        public IEnumerable<FioTransaction> Parse(Stream document)
        {
            var s = new XmlSerializer(typeof(AccountStatement));
            var deserialized = s.Deserialize(document) as AccountStatement;
            return deserialized.TransactionList.Select(t => Convert(t));
        }

        private FioTransaction Convert(AccountStatementTransaction transaction)
        {
            return new FioTransaction()
            {
                Amount = Extract(transaction.column_1),
                TransactionType = Extract(transaction.column_8),
                Comment = Extract(transaction.column_25),
                ConstantSymbol = Extract(transaction.column_4),
                Currency = Extract(transaction.column_14),
                MovementId = Extract(transaction.column_22),
                ContraAccount = Extract(transaction.column_2),
                ContraAccountBankCode = Extract(transaction.column_3),
                ContraAccountBankName = Extract(transaction.column_12),
                TransactionExecutive = Extract(transaction.column_9),
                TransactionId = Extract(transaction.column_17),
                MovementDate = Extract(transaction.column_0),
                VariableSymbol = Extract(transaction.column_5),
                SpecificSymbol = Extract(transaction.column_6),
                ContraAccountName = Extract(transaction.column_10),
                MessageForReceiver = Extract(transaction.column_16),
                Specification = Extract(transaction.column_18),
                UserIdentification = Extract(transaction.column_7)
            };
        }

        private T Extract<T>(IValue<T> value)
        {
            if (value == null)
                return default(T);
            return value.Value;
        }
    }
}
