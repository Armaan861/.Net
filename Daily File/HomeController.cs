using _22JULY2026.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _22JULY2026.Controllers
{
    public class HomeController : Controller
    {
        //display form
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //recive form data
        [HttpPost]
        public ActionResult Index(Product product)
        {
            if (ModelState.IsValid)
            {
                //normally save to db
                return Content($"Product : {product.Name} , "+ $" Price : { product.Price},"+$" Category : {product.Category}, "+$" Stock : {product.Stock}");
                    
            }
            return View(product);
        }
    }
}
