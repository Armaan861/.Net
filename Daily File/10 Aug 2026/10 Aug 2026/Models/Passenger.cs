using System.ComponentModel.DataAnnotations;

namespace _10_Aug_2026.Models
{
    public class Passenger
    {
       public int Id { get; set; }

        [Required(ErrorMessage =("Name is Required"))]
        public string? Name { get; set; }

        [Required(ErrorMessage = ("Phone is Required"))]
        [Phone(ErrorMessage ="Phone is required")]
        public string? Phones { get; set; }

        [Required(ErrorMessage = ("Email is Required"))]
        [EmailAddress(ErrorMessage ="Email is Incorrect")]

        public string ?Email { get; set; }
    }
}
