using Gnome.DataAccess;
using MediatR;
using System.Linq;

namespace Gnome.Services.Transaction
{
    public class GetTransactionHandler : IRequestHandler<GetTransactionsCommand, GetTransactionResponse>
    {
        private readonly GnomeDbContext context;

        public GetTransactionHandler(GnomeDbContext context)
        {
            this.context = context;
        }

        public GetTransactionResponse Handle(GetTransactionsCommand message)
        {
            var transactions = context
                .Transactions
                .Where(t => t.AccountId == message.AccountId)
                .ToList()
                .Select(t => new Api.Model.Transaction()
                {
                    Id = t.Id,
                    Amount = t.Amount,
                    Currency = t.Currency,
                    Comment = t.Comment,
                    ContraAccount = t.ContraAccount,
                    ConstantSymbol = t.ConstantSymbol,
                    ContraAccountName = t.ContraAccountName,
                    ContraAccountBankCode = t.ContraAccountBankCode,
                    ContraAccountBankName = t.ContraAccountBankName,
                    MovementId = t.MovementId,
                    MovementDate = t.MovementDate,
                    SpecificSymbol = t.SpecificSymbol,
                    VariableSymbol = t.VariableSymbol,
                    UserIdentification = t.UserIdentification,
                    MessageForReceiver = t.MessageForReceiver,
                    BankIndentifierCode = t.BankIndentifierCode,
                    Specification = t.Specification,
                    TransactionExecutive = t.TransactionExecutive,
                    TransactionId = t.TransactionId,
                    TransactionType = t.TransactionType

                })
                .ToList();
            return new GetTransactionResponse(transactions);
        }
    }
}
