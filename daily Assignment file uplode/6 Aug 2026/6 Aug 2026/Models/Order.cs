using Microsoft.OpenApi.MicrosoftExtensions;
using System.ComponentModel.DataAnnotations;

namespace _6_Aug_2026.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = " Name is Mandatory")]
        [StringLength(60, ErrorMessage =" Name is max upto 60")]
        public string Name { get; set; }



        [Required(ErrorMessage = " Price is Mandatory")]
        [Range (10 , 100000 , ErrorMessage = " Price is between 10 to 100000")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "Quantity is Mandatory")]
        [Range(1, 1000, ErrorMessage = "Quantity must be between 1 and 1000")]
        public int Quantity { get; set; }


    }
}
