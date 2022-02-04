using FluentAssertions;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using WebApi.Models;
using Newtonsoft.Json;
using System.Text;

namespace xunittest
{
    public class ProductApiIntegrationTest
    {
        [Fact]
        public async Task Test_Get_All()
        {

            using(var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/product");

                response.EnsureSuccessStatusCode();

                response.StatusCode.Should().Be(HttpStatusCode.OK);

                //Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

                //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }


        }

        [Fact]
        public async Task Test_Post()
        {
            using (var client = new TestClientProvider().Client)
            {
                Product product = new Product()
                {
                    Id = 5,
                    ProductName = "OnePlus",
                    Price = 650,
                    Qty = 130
                };


                //var response = await client.PostAsync("/api/product", new StringContent(JsonConvert.SerializeObject(new Product(){Id = 5,ProductName = "OnePlus",Price = 650,Qty = 130}) ,Encoding.UTF8, "application/json"));

                var response = await client.PostAsync("/api/product", new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json"));

                response.EnsureSuccessStatusCode();

                response.StatusCode.Should().Be(HttpStatusCode.OK);

               
            }
        }
    }
}
