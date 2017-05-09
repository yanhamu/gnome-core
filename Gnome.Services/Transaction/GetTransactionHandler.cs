using AutoMapper;
using Gnome.DataAccess;
using MediatR;
using System.Collections.Generic;
using System.Linq;

namespace Gnome.Services.Transaction
{
    public class GetTransactionHandler : IRequestHandler<GetTransactions, GetTransactionResponse>
    {
        private readonly GnomeDbContext context;
        private readonly IMapper mapper;

        public GetTransactionHandler(
            GnomeDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public GetTransactionResponse Handle(GetTransactions message)
        {
            var fioTransactions = context
                .Transactions
                .Where(t => t.AccountId == message.AccountId)
                .ToList();

            var result = mapper.Map<List<Api.Model.FioTransaction>>(fioTransactions);

            return new GetTransactionResponse(result);
        }
    }
}
