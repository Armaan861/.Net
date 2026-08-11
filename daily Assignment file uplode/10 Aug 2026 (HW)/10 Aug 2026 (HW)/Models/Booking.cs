using System.ComponentModel.DataAnnotations;

namespace _10_Aug_2026__HW_.Models
{
    public class Booking
    {
     
            public int Id { get; set; }

            [Required]
            public int VehicleId { get; set; }

            [Required]
            public int CustomerId { get; set; }

            [Required]
            public int LocationId { get; set; }

            [Required(ErrorMessage = "Start Date is required")]
            public DateTime StartDate { get; set; }

            [Required(ErrorMessage = "End Date is required")]
            public DateTime EndDate { get; set; }

            public decimal TotalCost { get; set; }

            // Navigation Properties
            public Vehicle? Vehicle { get; set; }
            public Customer? Customer { get; set; }
            public Location? Location { get; set; }
        }
    }


