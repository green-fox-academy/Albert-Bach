using Frontend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
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
        public void Test1()
        {

        }
    }
}
