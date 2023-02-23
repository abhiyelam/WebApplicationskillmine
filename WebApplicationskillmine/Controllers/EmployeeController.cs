using Microsoft.AspNetCore.Mvc;
using WebApplicationskillmine.Models;

namespace WebApplicationskillmine.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            ViewBag.Id = emp.Id;
            ViewBag.Name = emp.Name;
            ViewBag.Price = emp.Salary;
            ViewBag.Phoneno = emp.Phoneno;
            return View("Show");
        }
    }
}
