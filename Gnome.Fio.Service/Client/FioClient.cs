using Polly;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Gnome.Fio.Service.Client
{
    public class FioClient : IFioClient
    {
        private readonly FioRestClient restClient;

        public FioClient(FioRestClient restClient)
        {
            this.restClient = restClient;
        }

        public async Task<AccountStatement> GetAccountStatementAsync(string token, DateTime from, DateTime to)
        {
            var policy = Policy
                .HandleResult<IRestResponse<AccountStatement>>(r => r.StatusCode != System.Net.HttpStatusCode.OK)
                .WaitAndRetry(3, retryAttempts => TimeSpan.FromSeconds(5));

            var result = await policy.ExecuteAsync(() => restClient.GetAccountStatementAsync(token, from, to));
            return result.Data;
        }
    }
}