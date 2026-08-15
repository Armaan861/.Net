using System.ComponentModel.DataAnnotations;

namespace _12_Aug_2026.Models
{
    public class User
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Name is Required")]
        [StringLength(30, ErrorMessage = "10 max character stored in username")]
        public string UserName { get; set; } = string.Empty;


        [Required(ErrorMessage = "Passward is Required")]
        [StringLength(16, ErrorMessage = "16 max character stored in username")]
        public string Password { get; set; } = string.Empty;


        [Required(ErrorMessage = "Role is Required")]
        [StringLength(10, ErrorMessage = "10 max character stored in username")]
        public string Role { get; set; }
    }
}
