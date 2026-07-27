using System.ComponentModel.DataAnnotations;

namespace _27_july_2026__HW01_.Models
{
    public class Product
    {
        [Required(ErrorMessage ="Product ID is Required")]
        [Range(100,10000)]
        public int ProductId {  get; set; }
        [Required(ErrorMessage = "Product Name is Required")]   
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Product Catagory is Required")]
        public string Catagory { get; set; }
        [Required(ErrorMessage ="Category is Required")]
        public string Prize {  get; set; }
        [Required(ErrorMessage= "Brand is Required")]
        public string Brand { get; set; }
    }
}
