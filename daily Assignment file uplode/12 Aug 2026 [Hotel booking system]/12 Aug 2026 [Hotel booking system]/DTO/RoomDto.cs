using System.ComponentModel.DataAnnotations;

namespace _12_Aug_2026__Hotel_booking_system_.DTO
{
    public class RoomDto
    {
        
            public int HotelId { get; set; }

            public string RoomNumber { get; set; } = string.Empty;

            public string RoomType { get; set; } = string.Empty;

            public decimal Price { get; set; }
        }
    }

