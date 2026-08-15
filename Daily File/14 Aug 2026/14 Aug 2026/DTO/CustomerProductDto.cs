using System.ComponentModel.DataAnnotations;

namespace _14_Aug_2026.DTO
{
    public class CustomerProductDto
    {
        [Required]
        public int ProductId { get; set; }

        [Range(1,100)]
        public int Quantity { get; set; }

    }
}
