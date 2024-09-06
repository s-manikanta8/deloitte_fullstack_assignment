using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ProductDbContext _context;

        public HomeController(ProductDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> productList = _context.Products.ToList();
            return View(productList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product obj) {
            _context.Products.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
