using _23_JULY_2026.Models;
using Microsoft.AspNetCore.Mvc;

namespace _23_JULY_2026.Controllers
{
    public class HomeController : Controller
    {
        // GET: Loads the login page
        public IActionResult Index()
        {
            return View();
        }

        // POST: Handles form submission
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // Simple hardcoded login verification
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("User")))
            {
                return RedirectToAction("Index", "Product");
            }

            // If credentials fail, show error message on the page
            ViewBag.ErrorMessage = "Invalid username or password";
            return View();
        }

        
    }
}