using AutoMapper;
using Gnome.Api.Model;
using Gnome.DataAccess;
using MediatR;

namespace Gnome.Services.Transaction
{
    public class CreateFioTransactionHandler : IRequestHandler<CreateFioTransaction, FioTransaction>
    {
        private readonly GnomeDbContext context;
        private readonly IMapper mapper;

        public CreateFioTransactionHandler(GnomeDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public FioTransaction Handle(CreateFioTransaction message)
        {
            var fioTransaction = mapper.Map<DataAccess.Transaction>(message.Transaction);
            fioTransaction.AccountId = message.AccountId;

            context.Transactions.Add(fioTransaction);
            context.SaveChanges();

            return mapper.Map<FioTransaction>(fioTransaction);
        }
    }
}
