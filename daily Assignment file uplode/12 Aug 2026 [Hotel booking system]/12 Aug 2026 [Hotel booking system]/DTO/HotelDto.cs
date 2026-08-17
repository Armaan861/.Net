using System.ComponentModel.DataAnnotations;

namespace _12_Aug_2026__Hotel_booking_system_.DTO
{
    public class HotelDto
    {
        [Required(ErrorMessage ="Hotel Name is Mandatory")]
        [StringLength(50)]
        public string ?Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Hotel City is Mandatory")]
        [StringLength(50)]
        public string? City { get; set; } = string.Empty;



    }
}
