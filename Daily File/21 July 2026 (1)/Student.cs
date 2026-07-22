using System.ComponentModel.DataAnnotations;

namespace _21JULY2026
{
    public class Student
    {
        
        
            [Required(ErrorMessage = "Student name is mandatory")]
            [StringLength(28, MinimumLength = 3, ErrorMessage = "Student name should be minimum 3 and maximum 28 characters")]
             public string name { get; set; }

            [Required(ErrorMessage = "Student age is mandatory")]
            [Range(18, 25, ErrorMessage = "Age must be between 18 and 25 ")]
            public int age { get; set; }
            [Required(ErrorMessage = "Student email is mandatory")]

            [EmailAddress(ErrorMessage = "Enter a valid email address")]
            public string email { get; set; }
            [Required(ErrorMessage = "Student enrolled in course is mandatory")]

            public string course { get; set; }
        }
    }



