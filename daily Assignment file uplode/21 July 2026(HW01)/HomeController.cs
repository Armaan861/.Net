using _21_July_2026_HW01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _21_July_2026_HW01.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //recive form data
        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            //check if model is valid
            if (ModelState.IsValid)
            {
                // Put a "secret badge" into TempData to prove registration succeeded.
                // TempData survives redirection to another controller!
                TempData["RegistrationSuccess"] = true;
                return View("Department", employee);
            }
            
                return View( employee);
            
        }
    }       
}
