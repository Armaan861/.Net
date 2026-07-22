using System.ComponentModel.DataAnnotations;

namespace _22JULY_001_2026.Models
{
    public class Stationary
    {
        public int Id;

        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is mandatory")]
        [Range(1,10000)]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "Category is mandatory")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Stock is mandatory")]
        public int Stock { get; set; }
    }
}
