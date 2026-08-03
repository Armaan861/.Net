using System.ComponentModel.DataAnnotations;

namespace _28_july_2026.Controllers.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Product name must be between 5 and 10 characters.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Product quantity is required.")]
        [StringLength(100, ErrorMessage = "Product quantity must not exceed 100 characters.")] public string Description { get; set; }
        public string Quantity { get; set; }


        [Required(ErrorMessage = "Product price is required.")]
        [Range(10, 1000, ErrorMessage = "Product price must be between 10 and 1000.")]
        public decimal Price { get; set; }
    }
}
