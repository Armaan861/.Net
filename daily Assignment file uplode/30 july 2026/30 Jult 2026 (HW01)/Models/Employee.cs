using System.ComponentModel.DataAnnotations;

namespace _30_Jult_2026__HW01_.Models
{
    public class Employee
    {
     public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]

        public string  FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public long PhoneN { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public long Salary { get; set; }

        [Required(ErrorMessage = "Date of Joining is required")]
        public string DateOfJoining { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public string Department { get; set; }
        public string Designation { get; set; }
        public string EmploymentStatus { get; set; }


    }
}
