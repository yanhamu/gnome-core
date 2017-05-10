using Gnome.Transactions.Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gnome.Transactions.Uploader
{
    public class GnomeClient : IGnomeClient
    {
        private readonly Configuration configuration;

        public GnomeClient(Configuration configuration)
        {
            this.configuration = configuration;
        }

        public async Task SendAsync(FioTransaction transaction, Guid accountId)
        {
            //var token = await GetToken(configuration.Username, configuration.Password);
            //SendTransaction(transaction, accountId, token)

            throw new NotImplementedException();
            //TODO implement
        }

        public async Task<HttpResponseMessage> GetToken(string username, string password)
        {
            using (var httpClient = new HttpClient())
            {
                var parameters = new List<System.Collections.Generic.KeyValuePair<string, string>>() {
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password)
                };
                using (var content = new FormUrlEncodedContent(parameters))
                {
                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    return await httpClient.PostAsync("http://localhost:1862", content);
                }
            }
        }
    }
}