using System.ComponentModel.DataAnnotations;

namespace _12_Aug_2026__Hotel_booking_system_.DTO
{
    public class BookingRoomDto
    {
        [Required(ErrorMessage = "Price is Mandatory")]

        public decimal Price { get; set; }

    }
}
