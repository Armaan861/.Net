using System.ComponentModel.DataAnnotations;

namespace _24_JULY_2026.Models
{
    public class Student
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Passward { get; set; }















    }
}
