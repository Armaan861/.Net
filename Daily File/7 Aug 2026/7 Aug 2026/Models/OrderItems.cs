using System.Text.Json.Serialization;

namespace _7_Aug_2026.Models
{
    public class OrderItems
    {
        //primary key
        public int Id { get; set; }

        //foreign key referenciing product table
        public int? ProductId{ get; set; }

        //allow access to product detils
        [JsonIgnore]
        public Product? product { get; set; }

        //forign ke referincing oders table 
        public int OrderId { get; set; }

        // allow assess to order detils
        [JsonIgnore]
        public Orders? order { get; set; }

        //number of unit ordered
        public int Quantity { get; set; }

    }
}


//one order ----- one to many ------ orderItems
//one order contain many orderItem

//OrderItems----Many to one -----Product
//one Product is apper in many OrderItem


//OrderItem act as a bridge between  order and product