using System.Net.Http;
using System.Threading.Tasks;
using WebApplication;
using Xunit;

namespace Ardalis.ListStartupServices.Tests
{
    public class RootWebApplication : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public RootWebApplication(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnDefaultContent()
        {
            HttpResponseMessage response = await _client.GetAsync("/");
            response.EnsureSuccessStatusCode();
            string stringResponse = await response.Content.ReadAsStringAsync();

            Assert.Contains("Default content", stringResponse);
        }
    }
}
