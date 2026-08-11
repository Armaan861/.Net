using System.ComponentModel.DataAnnotations;

namespace _8_Aug_2026.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required(ErrorMessage ="Course Name is Required")]
        public string? CourseName { get; set; }

        [Range(1,24 ,ErrorMessage ="Course Duration is in between 1 to 24 months")]
        public int Duration { get; set; }

        //Foregian key
        public int TeacherId { get; set; }
        // Navigation Property: Belongs to ONE Teacher
        public Teacher? Teacher { get; set; }

        // Navigation Property: Many Courses to Many Students
        public ICollection <Student> ?Students { get; set; } 
    }
}
