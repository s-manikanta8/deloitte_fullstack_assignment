using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication4.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        EmployeDbContext _context;
        public HomeController(EmployeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // For POST Request
        [HttpPost]
        public IActionResult Login(int uid, string pwd)
        {
            User obj = _context.Users.Find(uid);
            if (obj == null) {
                ViewData["result"] = "Invalid User Id";
                    }
            else {

                if (uid == obj.UserID && pwd == obj.UserPassword)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewData["result"] = "Invalid User Id or Password";
                }
            }


            return View();
        }
        public IActionResult Index()
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
