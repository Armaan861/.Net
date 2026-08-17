using System.ComponentModel.DataAnnotations;

namespace _12_Aug_2026__Hotel_booking_system_.DTO
{
    public class CustomerDto
    {
        [Required(ErrorMessage = "Name is Required")]

        public string? Name { get; set; }
        [Required(ErrorMessage = "Email is Required")]

        public string? Email { get; set; }
    }
}
