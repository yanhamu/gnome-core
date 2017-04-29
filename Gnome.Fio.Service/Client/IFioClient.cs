using System;
using System.Threading.Tasks;

namespace Gnome.Fio.Service.Client
{
    public interface IFioClient
    {
        Task<AccountStatement> GetAccountStatementAsync(string token, DateTime from, DateTime to);
    }
}
