using Gnome.Fio.Downloader.Model;
using System.Collections.Generic;
using System.IO;

namespace Gnome.Fio.Downloader.Services
{
    public interface ITransactionParser
    {
        IEnumerable<FioTransaction> Parse(Stream document);
    }
}
