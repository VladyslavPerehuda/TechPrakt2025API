using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product1", Price = 18.99m },
            new Product { Id = 2, Name = "Product2", Price = 20.99m }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound("Продукт не знайдено");

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            product.Id = products.Count > 0 ? products.Max(p => p.Id) + 1 : 1;
            products.Add(product);
            return Created($"/api/products/{product.Id}", product);
        }

        [HttpPatch("{id}")]
        public IActionResult Update(int id, [FromBody] Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound("Продукт не знайдено");

            if (!string.IsNullOrEmpty(updatedProduct.Name))
                product.Name = updatedProduct.Name;

            if (updatedProduct.Price > 0)
                product.Price = updatedProduct.Price;

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound("Продукт не знайдено");

            products.Remove(product);
            return Ok(id);
        }
    }
}