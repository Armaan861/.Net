using _22JULY_001_2026.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _22JULY_001_2026.Controllers
{
    public class HomeController : Controller
    {
        //display Form
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //recive form data
        [HttpPost]
        public ActionResult Index(Stationary stationary)
        {
            if (ModelState.IsValid)
            {
                //normally save to db
                return Content($"StationaryName : {stationary.Name}, " + $" Price : {stationary.Price}," + $" Category : {stationary.Category}," + $" Stock : {stationary.Stock}");
            }
            else
            {
                return View(stationary);
            }

        }
    }
}
