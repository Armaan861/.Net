using Microsoft.OpenApi.MicrosoftExtensions;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8_Aug_2026.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage ="Name is Mandatory")]
        [StringLength(50 ,ErrorMessage ="First Name is Not Max Char 50")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage ="Last Name is required")]
        [StringLength(50 ,ErrorMessage = "Last Name is not Max 50")]
        public string ?Lastname { get; set; }

        [Required(ErrorMessage =" Email is Required")]
        [EmailAddress(ErrorMessage =" Invalid Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Phone no is required")]
        [Phone(ErrorMessage =" Invalid Phone")]
        public string? Phone {  get; set; }

        [Required(ErrorMessage ="Date of birth is required")]
        public string? DateOfBirth { get; set; }

        // Foreign Key for Batch
        public int BatchId { get; set; }


        //Relationship:
        //•	One Batch → Many Students
        public Batch ?Batch { get; set; }

        // Navigation Property: Many Students to Many Courses
        public ICollection<Course> ?Courses {  get; set; }


    }
}
