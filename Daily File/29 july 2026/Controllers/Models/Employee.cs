using System.ComponentModel.DataAnnotations;

namespace _29_july_2026.Controllers.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 30 characters")]
        public string Name { get; set; }

        [Range(8, 10,ErrorMessage ="Number must be 8 or 10 digit")]

        public long phoneN { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage =" Invalid Email Address")]

        public string Email { get; set; }

        [Required(ErrorMessage = "DeptId is required")]

        public int DeptId { get; set; }
    }
}
