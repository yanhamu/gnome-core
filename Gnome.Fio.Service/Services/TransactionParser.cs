using Gnome.Fio.Service.Model;
using Gnome.Fio.Service.Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace Gnome.Fio.Downloader.Services
{
    public class TransactionParser : ITransactionParser
    {
        public IEnumerable<FioTransaction> Parse(Stream document)
        {
            throw new NotImplementedException();
        }
    }
}
