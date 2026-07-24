using _21_July_2026_HW01.Models;
using Microsoft.AspNetCore.Mvc;

namespace _21_July_2026_HW01.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index(string department)
        {
            if (TempData["RegistrationSuccess"] != null && (bool)TempData["RegistrationSuccess"] == true)
            {
                // Keep the badge alive in case the user refreshes the page
                TempData.Keep("RegistrationSuccess");

                // For beginners: We are creating a fake list of departments in memory
                // instead of connecting to a real SQL database to keep things simple.
                List<Department> departments = new List<Department>
                {
                    new Department { DepartmentName = "IT", DepartmentHead = "Alice Smith", HeadContactNumber = "555-0101", HeadEmail = "alice@company.com" },
                    new Department { DepartmentName = "HR", DepartmentHead = "Bob Jones", HeadContactNumber = "555-0102", HeadEmail = "bob@company.com" },
                    new Department { DepartmentName = "Finance", DepartmentHead = "Carol Taylor", HeadContactNumber = "555-0103", HeadEmail = "carol@company.com" }
                };
                return View(departments);
            }
            // IF THE USER DID NOT REGISTER: 
            // Kick them back to the Home Index (Registration) page!
            return RedirectToAction("Index", "Home");

        }
    }
}