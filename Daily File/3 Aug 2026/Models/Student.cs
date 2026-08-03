using System.ComponentModel.DataAnnotations;

namespace _3_Aug_2026.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(30, MinimumLength = 3 ,ErrorMessage = "Student name must in between 3 to 30")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(18,25 ,ErrorMessage = "Student age must between 18 to 25")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Course is required.")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]

        public string Email { get; set; }


    }
}
