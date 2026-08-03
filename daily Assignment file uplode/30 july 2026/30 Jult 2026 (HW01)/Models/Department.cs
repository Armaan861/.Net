using System.ComponentModel.DataAnnotations;

namespace _30_Jult_2026__HW01_.Models
{
    public class Department
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Department Name is Mandatory")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Minimum length is between 2 to 30 characters")]
        public string Name { get; set; }
        public int Code { get; set; }

        [Required(ErrorMessage = "Status must Valid or Invalid")]
        public string Status { get; set; }

    }
}
