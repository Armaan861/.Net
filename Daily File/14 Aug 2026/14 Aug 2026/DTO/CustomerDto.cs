using System.ComponentModel.DataAnnotations;

namespace _14_Aug_2026.DTO
{
    public class CustomerDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Passwared { get; set; } = string.Empty;
    }
}
