using _27_july_2026__HW01_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace _27_july_2026__HW01_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<Product> products = new List<Product>() { 
        
            new Product(){ ProductId=101,ProductName="Dhoop",Catagory="Essential",Prize="10",Brand="Cycle"},
            new Product(){ ProductId=102,ProductName="Agar",Catagory="Ess",Prize="100",Brand="Abc"},
            new Product(){ ProductId=103,ProductName="Dhoop",Catagory="Essential",Prize="100",Brand="Armaan"},

        };

        [HttpGet]
        public IActionResult Product()
        {
            return Ok (products);
        }


        //get product by id
        [HttpGet("{id}")]
        public IActionResult GetEmployeeByProductId(int Id)
        {
            var product = products.FirstOrDefault(e=> e.ProductId== Id);
            {
                if (product==null)
                {
                    return NotFound();
                }
            }
            return Ok(product);
        }


        //add  new product
        //
        [HttpPut("{id}")]
        public IActionResult AddProduct (Product product)
        {
            products.Add(product);
            return Ok(product); 
        }



        //add new product record
        [HttpPost]
        public IActionResult AddEmployee(Product product)
        {

            products.Add(product);
            return Ok(product); // 201 Created
        }

    }
}

