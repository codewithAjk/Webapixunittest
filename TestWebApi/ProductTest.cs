using NUnit.Framework;
using WebApi.Controllers;
using WebApi.Models;

namespace TestWebApi
{
    [TestFixture]
    public class Tests
    {

        ProductController pc;

        [SetUp]
        public void Setup()
        {
            pc = new ProductController();

        }

        [Test]
        public void Test1()
        {
            var PC = new ProductController();

            

            Assert.Pass("/api/product");
        }
    }
}