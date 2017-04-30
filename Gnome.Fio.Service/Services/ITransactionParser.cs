using Gnome.Fio.Service.Model;
using System.Collections.Generic;
using System.IO;

namespace Gnome.Fio.Service.Services
{
    public interface ITransactionParser
    {
        IEnumerable<FioTransaction> Parse(Stream document);
    }
}
