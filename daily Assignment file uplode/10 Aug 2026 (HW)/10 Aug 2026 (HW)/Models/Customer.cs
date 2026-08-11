using System.ComponentModel.DataAnnotations;

namespace _10_Aug_2026__HW_.Models
{

        public class Customer
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "Full Name is required")]
            public string FullName { get; set; } = string.Empty;

            [Required(ErrorMessage = "Email is required")]
            [EmailAddress(ErrorMessage = "Invalid Email Address")]
            public string Email { get; set; } = string.Empty;

            [Required(ErrorMessage = "Phone Number is required")]
            [Phone(ErrorMessage = "Invalid Phone Number")]
            public string PhoneNumber { get; set; } = string.Empty;

            [Required(ErrorMessage = "Driver License Number is required")]
            public string DriverLicenseNumber { get; set; } = string.Empty;
        }
    }

