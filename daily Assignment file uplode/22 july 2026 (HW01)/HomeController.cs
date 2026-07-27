using _22_JULY_2026__HW01_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _22_JULY_2026__HW01_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //recive form data
        [HttpPost]
        public IActionResult Index(Automobile automobile)
        {
            if (ModelState.IsValid)
            {
                return Content($"VehicleName :{automobile.VehicleName}," +
                    $"" +$" Brand  :{automobile.Brand }," +
                    $"" +$" Model  :{automobile.ModelYear }, " +
                    $"" +$"Price: {automobile.Price} ," +
                    $"" +$"Fuel Type :{automobile.FuelType} ");
            }
            return View(automobile);
        }
       
    }
}
