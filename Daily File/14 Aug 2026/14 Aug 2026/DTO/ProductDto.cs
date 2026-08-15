using System.ComponentModel.DataAnnotations;

namespace _14_Aug_2026.DTO
{
    public class ProductDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Range(0.01 , double.MaxValue)]
        public decimal Price { get; set; }
    }
}
