using _21JULY2026.Models;
using Microsoft.AspNetCore.Mvc;

namespace _21JULY2026.Controllers
{
    public class HomeController : Controller
    {
        //display form
        public IActionResult Register()
        {
            return View();
        }

        //handle form submission
        [HttpPost]

        public ActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                //  ViewBag.Message = "Student"+student.name +"Registered Successfully in collage";
                TempData["StudentName"] = student.name;
                return RedirectToAction("Schedule");

            }
            return View(student);
        }
        //cource schedule publiv page
        ActionResult Schedule(){
            List<Course> course = new List<Course>()
                {
                    new Course {courseName ="asp.net",sem="sem 5" , sessionTime ="11 dfdf",days ="Monday"},
                    new Course { courseName ="java", sem ="sem 3", sessionTime="9.30am - 11.00am", days="tue - wed"},
                    new Course { courseName ="html", sem ="sem 3", sessionTime="9.30am - 11.00am", days="fri - sat"},
            }; 
                return View(course);
            }
        
            }
        }
    

