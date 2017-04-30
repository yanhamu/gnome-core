using System.IO;

namespace Gnome.Fio.Service.Services
{
    public interface ITransactionParser
    {
        AccountStatement Parse(Stream document);
    }
}
