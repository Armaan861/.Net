using System.ComponentModel.DataAnnotations;

namespace _27_july_26.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50,MinimumLength =3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name must be between 3 and 50 characters")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Department is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Department must be between 3 and 50 characters")]
        public string Dept {  get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [Range(1000000000, 9999999999, ErrorMessage = "Invalid phone number")]
        public long PhoneNum {  get; set; }


        public string Profile { get; set; }
        
        public string Location { get; set; }

    }
}
