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
            // 1. Verify credentials (example hardcoded check)
            if (username == "admin" && password == "admin")
            {
                // 2. SET the session so the user stays logged in
                HttpContext.Session.SetString("User", username);

                // 3. Redirect to Product Controller's Index action
                return RedirectToAction("Index", "Product");
            }

            // If credentials fail, show error
            ViewBag.ErrorMessage = "Invalid username or password";
            return View();
        }
        public IActionResult Logout()
        {
            // Clears the saved session data
            HttpContext.Session.Clear();

            // Redirects back to the login page
            return RedirectToAction("Index", "Home");
        }

    }

        
    }
