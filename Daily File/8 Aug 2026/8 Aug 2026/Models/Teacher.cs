using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8_Aug_2026.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required(ErrorMessage ="Name is Mandatory")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is Mandatory")]
        public string ?Email { get; set; }

        [Range(1, 40, ErrorMessage = "Experiance is between 1 to 40")]

        public int Experience { get; set; }


      //        Relationship:
      //•	One Teacher → Many Courses
      public ICollection<Course>? Courses { get; set; }

        


    }
}
