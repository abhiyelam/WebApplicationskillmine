using Microsoft.AspNetCore.Mvc;
using WebApplicationskillmine.Models;
namespace WebApplicationskillmine.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product {Id=1,Name="laptop",Price=30000 },
                new Product {Id = 2, Name = "mobile", Price = 20000 },
               new Product { Id = 3, Name = "watch", Price = 3000 },
            };
            ViewData["productlist"]=products;
            //return View();

            TempData["message"] = "welcome to the mvc core";
            TempData.Keep("message");
            
                List<Product> products1 = new List<Product>()
                {
                new Product {Id=1,Name="laptop",Price=30000 },
                new Product {Id = 2, Name = "mobile", Price = 20000 },
               new Product { Id = 3, Name = "watch", Price = 3000 },
                };
                ViewBag.productlist = products1;
                return View();
            
            
        }
       
    }
}
