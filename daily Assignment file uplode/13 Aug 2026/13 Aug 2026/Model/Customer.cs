using System.ComponentModel.DataAnnotations;

namespace _13_Aug_2026.Model
{
    public class Customer
    {
        public int Id { get; set; }
        [Required (ErrorMessage = " Name is Required")]
        [StringLength (30 ,ErrorMessage ="30 is Max")]
        public string? Name { get; set; } = string.Empty;
        [Required(ErrorMessage ="Password is Required")]
        public string? Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Role is Required")]
        public string Email { get; set; } = string.Empty;

        public string? Role { get; set; } = string.Empty;
    }
}
