using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;


namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        public SalesDbContext _context;

        public ProductApiController(SalesDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAllProduct()
        {
            List<Product> Product = _context.Products.ToList();
            return Ok(Product);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _context.Products.Find(id);

            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound(new { status = "Requested Product details does not exists." });
            }
        }

        [HttpPost]
        public IActionResult CreateProduct(Product obj)
        {
            _context.Products.Add(obj);
            _context.SaveChanges();
            return Ok(new { status = "New Product details added in server." });
        }

        [HttpPut]
        public IActionResult EditProduct(Product obj)
        {
            _context.Products.Update(obj);
            _context.SaveChanges();
            return Ok(new { status = "Product details updated in server." });
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteProductById(int id)
        {
            Product obj = _context.Products.Find(id);

            if (obj != null)
            {
                _context.Products.Remove(obj);
                _context.SaveChanges();
                return Ok(new { status = "Product details are deleted from server." });
            }
            else
            {
                return NotFound(new { status = "Requested Product details does not exists." });
            }
        }

    }
}
