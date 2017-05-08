using System;

namespace Gnome.Api.Model
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }

        public DateTime MovementDate { get; set; }

        public string MovementId { get; set; }

        public string Currency { get; set; }

        public string ContraAccount { get; set; }

        public string ContraAccountName { get; set; }

        public string ContraAccountBankCode { get; set; }

        public string ContraAccountBankName { get; set; }

        public string ConstantSymbol { get; set; }

        public string VariableSymbol { get; set; }

        public string SpecificSymbol { get; set; }

        public string UserIdentification { get; set; }

        public string MessageForReceiver { get; set; }

        public string TransactionType { get; set; }

        public string TransactionExecutive { get; set; }

        public string Specification { get; set; }

        public string Comment { get; set; }

        public string BankIndentifierCode { get; set; }

        public long TransactionId { get; set; }
    }
}
