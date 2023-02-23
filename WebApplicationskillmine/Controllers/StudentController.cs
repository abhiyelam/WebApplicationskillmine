using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationskillmine.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Registrationform()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrationform(IFormCollection form)
        {
            ViewBag.Name = form["Name"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Mobileno = form["Mobileno"];
            ViewBag.Email = form["email"];
            ViewBag.Percentage = form["percentage"];
            return View("Display");
        }
    }
}
