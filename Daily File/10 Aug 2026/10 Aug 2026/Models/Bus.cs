using System.ComponentModel.DataAnnotations;

namespace _10_Aug_2026.Models
{
    public class Bus
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="BusName is Required")]
        public string ?BusName { get; set; }

        [Required(ErrorMessage = "TotalSeats is Required")]
        [Range(1,50)]
        public int TotalSeats { get; set; }

        [Required(ErrorMessage = "BusType is Required")]
        public string? BusType { get; set; }
    }
}
