using System.ComponentModel.DataAnnotations;

namespace _10_Aug_2026.Models
{
    public class State
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "StateName is Required")]
        [StringLength(50)]
        public string ?StateName { get; set; }
    }
}
