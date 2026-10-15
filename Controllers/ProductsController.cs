using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pract6_Borisov.Models;

namespace pract6_Borisov.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController :ControllerBase
    {
        private WebApiDatabaseContext _context;
        public ProductsController(WebApiDatabaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll([FromQuery] string? category, [FromQuery] decimal? minPrice)
        {
            var products = _context.Products.ToList();
            if (minPrice.HasValue && minPrice.Value < 0)
            {
                return BadRequest(new { message = "минимальная цена не может быть отрицательной" });
            }
            if (!string.IsNullOrEmpty(category))
            {
                if (category.Length > 25)
                {
                    return BadRequest(new { message = "Название категории слишком длинное" });
                }
                products = products.Where(x => x.Category == category).ToList();
            }
            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Price >= minPrice.Value).ToList();
            }
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { message = "id не может быть отрицательным" });
            }
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            var existingpProduct = _context.Products.FirstOrDefault(x => x.Id == id);
            if (existingpProduct == null)
            {
                return NotFound();
            }
            existingpProduct.Name = product.Name;
            existingpProduct.Price = product.Price;
            existingpProduct.Quantity = product.Quantity;
            existingpProduct.Category = product.Category;
            existingpProduct.IsAvailable = product.IsAvailable;
            _context.SaveChanges();
            return NoContent();
        }
        [HttpPatch("{id:int}")]
        public IActionResult Patch(int id, [FromBody] bool isAvalible)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            product.IsAvailable = isAvalible;
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
