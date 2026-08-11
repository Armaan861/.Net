using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8_Aug_2026.Models
{
    public class Batch
    {
        public int BatchId { get; set; }

        [Required(ErrorMessage= "Batch name is a Required")]
        public string ?BatchName { get; set; }

        [Required(ErrorMessage ="Starting date is Required")]
        public int StartDate { get; set; }


        // Relationship:
          // •	One Batch → Many Students
        public ICollection<Student>? Students { get; set; }

    }
}
