using WebApplication4.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Controllers
{
    public class EmployeController : Controller
    {
        EmployeDbContext _context;

        public EmployeController(EmployeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Employe> EmployeList = _context.Employes.ToList();
            return View(EmployeList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employe obj)
        {
            _context.Employes.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Employe obj = _context.Employes.Find(id);
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employe obj = _context.Employes.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Employe obj)
        {
            _context.Employes.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employe obj = _context.Employes.Find(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            Employe obj = _context.Employes.Find(id);
            _context.Employes.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Hylink()
        {
            var employeList = _context.Employes.ToList();
            return View(employeList);
        }
        public ActionResult EmployeesByDepartment(string department)
        {
            var employees = _context.Employes.Where(e => e.Department == department).ToList();
            return View(employees);
        }

    }
}
