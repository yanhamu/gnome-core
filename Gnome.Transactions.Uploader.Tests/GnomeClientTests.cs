using System.Threading.Tasks;
using Xunit;

namespace Gnome.Transactions.Uploader.Tests
{
    public class GnomeClientTests
    {
        [Fact]
        public async Task Should_Retrieve_Token()
        {
            var configuration = new Configuration("tajneHeslo", "tajneHeslo", "http://localhost:1862");
            var client = new GnomeClient(configuration);

            var token = await client.GetToken(configuration.Username, configuration.Password);
        }
    }
}
