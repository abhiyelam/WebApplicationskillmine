using Microsoft.AspNetCore.Mvc;
using WebApplicationskillmine.Models;

namespace WebApplicationskillmine.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            ViewBag.Id = book.Id;
            ViewBag.Name=book.Name;
            ViewBag.Price=book.Price;
            return View("Show");
        }
    }
}
