using Gnome.Api.Model;
using MediatR;
using System;

namespace Gnome.Services.Transaction
{
    public class CreateFioTransactionHandler : IRequestHandler<CreateFioTransaction, FioTransaction>
    {
        public FioTransaction Handle(CreateFioTransaction message)
        {
            throw new NotImplementedException();
        }
    }
}
