using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using task_8_4_2025.Server.Models;

namespace task_8_4_2025.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MyDbContext _context;
        public ProductController(MyDbContext context) { 
        _context = context;
        }


        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            var categories = _context.Categories.ToList();

            return Ok(categories);
        }

        [HttpGet("GetFirstCategory")]
        public IActionResult GetFirstCategory()
        {
            var firstCategory = _context.Categories.FirstOrDefault();

            return Ok(firstCategory);
        }

        [HttpGet("GetCategoryByID")]
        public IActionResult GetCategoryByID(int id)
        {
            var category = _context.Categories.Find(id);

            return Ok(category);
        }

        [HttpGet("GetCategoryByName")]
        public IActionResult GetCategoryByName(string name)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryName == name);

            return Ok(category);
        }

        //////////////////////////////////////////////////////////////////////////////////////

        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products.ToList();

            return Ok(products);
        }

        [HttpGet("GetFirstProduct")]
        public IActionResult GetFirstProduct()
        {
            var firstProduct = _context.Products.FirstOrDefault();

            return Ok(firstProduct);
        }

        [HttpGet("GetProductByID")]
        public IActionResult GetProductByID(int id)
        {
            var product = _context.Products.Find(id);

            return Ok(product);
        }

        [HttpGet("GetProductByName")]
        public IActionResult GetProductByName(string name)
        {
            var product = _context.Products.FirstOrDefault(c => c.Name == name);

            return Ok(product);
        }
    }
}
