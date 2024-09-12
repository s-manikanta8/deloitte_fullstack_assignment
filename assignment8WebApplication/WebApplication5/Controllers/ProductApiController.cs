using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;
using WebApplication5.Services;
using Microsoft.AspNetCore.Authorization;


namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductApiController : ControllerBase
    {
        IProductServices _service;
        public ProductApiController(IProductServices service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAllProduct()
        {
            return Ok(_service.GetAllProducts());
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            if (_service.GetProductById(id)!= null)
            {
                return Ok(_service.GetProductById(id));
            }
            else
            {
                return NotFound(new { status = "Requested Product details does not exists." });
            }
        }
        [Route("[action]/{Category}")]
        [HttpGet]
        public IActionResult GetProductbyCategory(string Category)
        {
            if (_service.GetProductbyCategory(Category) != null)
            {
                return Ok(_service.GetProductbyCategory(Category));
            }
            else
            {
                return NotFound(new { status = "Requested category  does not exists." });
            }
        }
        [Route("[action]")]
        [HttpGet]
        public IActionResult GetOutStock()
        {
            if (_service.GetOutStock() != null)
            {
                return Ok(_service.GetOutStock());
            }
            else
            {
                return NotFound(new { status = "no products are in out of stock." });
            }
        }
        [Route("[action]/{minprice}/{maxprice}")]
        [HttpGet]
        public IActionResult GetPriceRangePrdcts(int minprice, int maxprice)
        {
            if (_service.GetPriceRangePrdcts(minprice,maxprice) != null)
            {
                return Ok(_service.GetOutStock());
            }
            else
            {
                return NotFound(new { status = "no products are in out of stock." });
            }
        }

        [HttpPost]
        public IActionResult CreateProduct(Product obj)
        {
            return Ok(new { status = _service.AddProduct(obj) });
        }

        [HttpPut]
        public IActionResult EditProduct(Product obj)
        {
            return Ok(new {status = _service.UpdateProduct(obj)});
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteProductById(int id)
        {
            return Ok(new { status = _service.DeleteProduct(id) });
        }

    }
}
