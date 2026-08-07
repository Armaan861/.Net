using System.ComponentModel.DataAnnotations;

namespace _7_Aug_2026.Models
{
    public class Product
    {
        //primary key
        public int Id { get; set; }

        [Required(ErrorMessage =" Name is Mandatory")]
        public string Name { get; set; }


        [Required(ErrorMessage = " Price is Mandatory")]
        [Range(15,100000)]
        public decimal Price { get; set; }


        [Required(ErrorMessage = " Stock is Mandatory")]
        [Range(0 , 500)]
        public int Stock { get; set; }

        //one product can apper in many order items
        //EF uset  this  property to load related orderitems records

        public ICollection <OrderItems> OrderItems { get; set; }

    }
}
