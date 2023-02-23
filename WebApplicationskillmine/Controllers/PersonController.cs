using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace WebApplicationskillmine.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonDetails()
        {
            List<string> cities = new List<string>() { "select city","pune", "Nashik", "Latur", "Nagar", "Solapur" };
            ViewData["cities"] = newSelectList(cities);
            return View();
        }

        private object newSelectList(List<string> cities)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult PersonDetails(IFormCollection form,ICollection<string> hobbies)
        {
            ViewBag.Name = form["Name"];
            ViewBag.Phone = form["phone"];
            ViewBag.Gender = form["Gender"];
            ViewBag.city = form["cities"];
            ViewBag.Hobbies=hobbies;
            return View("Details");
        }
    }
}
