using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace _6_Aug__2026.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // primary key

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength ( 60, ErrorMessage = "Product name must be between 0 and 60 characters.")]
        public string PName { get; set; }

        [Required(ErrorMessage  =" Price is Required")]
        [Range(15 , 1000000, ErrorMessage = "Price must be between 15 and 1000000.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Availability is required.")]
        [StringLength(3,  ErrorMessage = "Product is max of 3 characters.")]
        public string Availability { get; set; }
    }
}
