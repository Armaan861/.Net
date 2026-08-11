using System.ComponentModel.DataAnnotations;

namespace _10_Aug_2026__HW_.Models
{
    public class Location
    {


        
            public int Id { get; set; }

            [Required(ErrorMessage = "Branch Name is required")]
            public string BranchName { get; set; } = string.Empty;

            [Required(ErrorMessage = "City is required")]
            public string City { get; set; } = string.Empty;
        }
    }
