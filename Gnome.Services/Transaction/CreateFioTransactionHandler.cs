using AutoMapper;
using Gnome.Api.Model;
using Gnome.DataAccess;
using MediatR;

namespace Gnome.Services.Transaction
{
    public class CreateFioTransactionHandler : IRequestHandler<CreateFioTransaction, Api.Model.FioTransaction>
    {
        private readonly GnomeDbContext context;
        private readonly IMapper mapper;

        public CreateFioTransactionHandler(
            GnomeDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Api.Model.FioTransaction Handle(CreateFioTransaction message)
        {
            var fioTransaction = mapper.Map<DataAccess.FioTransaction>(message.Transaction);
            fioTransaction.AccountId = message.AccountId;

            context.Transactions.Add(fioTransaction);
            context.SaveChanges();

            return mapper.Map<Api.Model.FioTransaction>(fioTransaction);
        }
    }
}
