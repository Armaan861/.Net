using System.ComponentModel.DataAnnotations;

namespace _7_Aug_2026.Models
{
    public class Orders
    {
        //primary key
        public int Id { get; set; }

        [Required(ErrorMessage= "Coustmer Name is required")]
        public string CustomerName { get; set; }

        //stores order cretion date ,default to current date and time
        public DateTime OrderDate { get; set; } = DateTime.Now;
        
        //one order can contain multiple order items
        public ICollection<OrderItems> OrderItems { get; set; }

    }
}
