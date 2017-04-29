using RestSharp;
using System;
using System.Threading.Tasks;

namespace Gnome.Fio.Service.Client
{
    public class FioRestClient
    {
        private readonly string baseUrl;

        public FioRestClient(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public Task<IRestResponse<AccountStatement>> GetAccountStatementAsync(string token, DateTime from, DateTime to)
        {
            var client = new RestClient();
            var request = new RestRequest("periods/{token}/{from}/{to}/transactions.xml");

            request.AddUrlSegment("token", token);
            request.AddUrlSegment("from", from.ToString("yyyy-MM-dd"));
            request.AddUrlSegment("to", to.ToString("yyyy-MM-dd"));

            var taskSource = new TaskCompletionSource<IRestResponse<AccountStatement>>();
            var result = client.ExecuteAsync<AccountStatement>(request, r => taskSource.SetResult(r));

            return taskSource.Task;
        }
    }
}
