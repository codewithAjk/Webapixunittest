using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Id = 1, ProductName = "Iphone", Price = 1200, Qty = 10 });
            products.Add(new Product { Id = 2, ProductName = "Samsung", Price = 1050, Qty = 35 });
            products.Add(new Product { Id = 3, ProductName = "Mi", Price = 780, Qty = 23 });
            products.Add(new Product { Id = 4, ProductName = "Oppo", Price = 980, Qty = 40 });

            return Ok(products);

        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {

            return Ok();

        }

    }
}
