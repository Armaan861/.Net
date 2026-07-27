using _24_JULY_2026.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _24_JULY_2026.Controllers
{
    public class HomeController : Controller
    {
        //Get Login
        public IActionResult Index()
        {
            return View();
        }


        //Post :login
        [HttpPost]
        public ActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.UserName == "Armaan" && student.Passward == "123456")
                {
                    HttpContext.Session.SetString("User", student.Passward);//change karka deak student.Passward 
                    return RedirectToAction("Dashboard");
                }
                ViewBag.Error = "Invalid username or password";
            }
            return View(student);
        }

        //dashboard

        public ActionResult Dashboard()
        {
            var user = HttpContext.Session.GetString("User");
            if
                (string.IsNullOrEmpty(user))
            {
                return RedirectToAction("Index");
            }
            ViewBag.User = user;
            return View();
        }


        //logout
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}