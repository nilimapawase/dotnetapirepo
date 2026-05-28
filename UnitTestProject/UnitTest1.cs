using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var factory = new WebApplicationFactory<Program>();
            var client=factory.CreateClient();
            var response = await client.GetAsync("/api/states");
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(200, (int)response.StatusCode);
        }
        [Theory]
        [InlineData(1,200)]
        [InlineData(2,200)]
        [InlineData(15,204)]
        [InlineData(11,204)]
        public async Task Test2(int id,int expected)
        {
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync($"/api/state/{id}");
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, (int)response.StatusCode);
        }
    }
}