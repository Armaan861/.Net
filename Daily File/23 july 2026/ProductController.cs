using _23_JULY_2026.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace _23_JULY_2026.Controllers
{
    public class ProductController : Controller

    {

        public IActionResult Index()
        {
            //check login
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("User")))
            {
                return RedirectToAction("Login", "Home");
            }
                List<Product> products = new List<Product>
                {
                    new Product { Id = 1, Name = "Product 1", Price = 10.99m },
                    new Product { Id = 2, Name = "Product 2", Price = 19.99m },
                    new Product { Id = 3, Name = "Product 3", Price = 5.99m }
                };
                return View(products);
            
        }

        }
    }

