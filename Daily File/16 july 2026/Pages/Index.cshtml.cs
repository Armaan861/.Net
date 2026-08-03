using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace _16JUL2026.Pages
{
    public class IndexModel : PageModel
    {
        // This is the property you will loop through in your HTML
        public List<Student1> Students { get; set; } = new List<Student1>();

        public void OnGet()
        {
            // Adding sample data to display in the table
            Students = new List<Student1>
            {
                new Student1 { ID = 101, Name = "Armaan Gupta", Age = 20, Course = "Computer Science" },
                new Student1 { ID = 102, Name = "Rohan Sharma", Age = 21, Course = "Information Technology" },
                new Student1 { ID = 103, Name = "Priya Patel", Age = 19, Course = "Data Science" }
            };
        }
    }
}