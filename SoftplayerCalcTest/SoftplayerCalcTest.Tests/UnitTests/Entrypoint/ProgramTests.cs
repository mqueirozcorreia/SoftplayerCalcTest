using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using SoftplayerCalcTest.Api;
using Xunit;

namespace SoftplayerCalcTest.Tests.UnitTests.Entrypoint
{
    public class ProgramTests
    {
        [Fact]
        public async Task CanGetHomePage()
        {
            var webHostBuilder = Program.CreateWebHostBuilder(Array.Empty<string>())
                .UseContentRoot(Path.GetFullPath("../../../../../SoftplayerCalcTest"));

            var server = new TestServer(webHostBuilder);
            var client = server.CreateClient();

            var response = await client.GetAsync("/showmethecode");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
