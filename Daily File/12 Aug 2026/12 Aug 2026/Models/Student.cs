using System.ComponentModel.DataAnnotations;

namespace _12_Aug_2026.Models
{
    public class Student
    {
        public int Id { get; set; }//

        [Required(ErrorMessage =" Name is Required")]
        [StringLength(30 ,MinimumLength =3 ,ErrorMessage ="Name length is between 3 to 30")]
        public string Name { get; set; }//

        [Required(ErrorMessage = " Age is Required")]
        [Range(18 ,25,ErrorMessage= "Age is between 18 to 25")]
        public int Age { get; set; } //

        [Required(ErrorMessage = " Mail is Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Email length is between 3 to 30")]
        [EmailAddress(ErrorMessage ="Mail id is incorrect")]
        public string Mail { get; set; }//


        [Required(ErrorMessage = " PhoneNumber is Required")]
        [Phone(ErrorMessage = "Phone no is incorrect")]
        public string PhoneNumber { get; set; }//

        [Required(ErrorMessage = " Course is Required")]
        [StringLength(30,  ErrorMessage = "Email length is max 30")]
        public string Course { get; set; }//
    }
}
