using Frontend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FrontendIntegrationTest
{
    public class UnitTest1
    {
        private TestServer Server;
        private HttpClient Client;

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatusForDouble()
        {
            var response = await Client.GetAsync("/doubling");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForGreeting()
        {
            var response = await Client.GetAsync("/greeter");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForAppendA()
        {
            var response = await Client.GetAsync("/appenda/{appendable}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnNotFoundForAppend()
        {
            var response = await Client.GetAsync("/appenda");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForDoUntil()
        {
            var response = await Client.GetAsync("/dountil/{what}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForArray()
        {
            var response = await Client.GetAsync("/array");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnErrorMessageWithNullInputSum()
        {
            var data = new StringContent(content: "", encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("dountil/sum", data);
            var responseString = await response.Content.ReadAsStringAsync();

            string error = "{\"error\":\"Please provide a number!\"}";

            Assert.Equal(error, responseString);
        }
    }
}
