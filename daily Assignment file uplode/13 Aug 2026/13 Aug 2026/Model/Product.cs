using System.ComponentModel.DataAnnotations;

namespace _13_Aug_2026.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Name is Required ")]
        [StringLength(50,ErrorMessage =" 50 is Max Length")]
        public string? Name { get; set; }
        [Required(ErrorMessage = " Description is Required")]
        public string ?Description { get; set; }
        [Required(ErrorMessage ="Stock is Required")]
        public string ? Stock {  get; set; }
        [Required(ErrorMessage =" Priice is Required")]
        [Range(0 ,100000000,ErrorMessage=" Pricce is Between 0 t 100000")]
        public decimal Price { get; set; }
    }
}
