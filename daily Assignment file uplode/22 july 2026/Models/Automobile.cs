using System.ComponentModel.DataAnnotations;

namespace _22_JULY_2026__HW01_.Models
{
    public class Automobile
    {
        public int VechicalId { get; set; }

        [Required(ErrorMessage ="Name is Mandatory")]
        public string VehicleName { get; set; }
        [Required(ErrorMessage = "Brand is Mandatory")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Model Year is Mandatory")]
        [Range(1900, 2099, ErrorMessage = "Invalid Model Year")]
        public string ModelYear { get; set; }

        [Required(ErrorMessage = "Price is Mandatory")]
        public string Price { get; set; }

        [Required(ErrorMessage ="Fuel type is Mandatory")]

        public string FuelType { get; set; }


    }
}
