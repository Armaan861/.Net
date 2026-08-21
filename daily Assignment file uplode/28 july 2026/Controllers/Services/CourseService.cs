using _28_july_2026__HW01_.Controllers.Models;

namespace _28_july_2026__HW01_.Controllers.Services
{
    public class CourseService : ICourseService

    {
        private static List<Course> courses = new List<Course>()
        {
            new Course{Id = 1 , Title = "CSE" , Duration = 10 , Credits = 3},
            new Course{Id = 2 , Title = "CE" , Duration = 8 , Credits = 3},
            new Course{Id = 3 , Title = "CSE&Ai" , Duration = 10 , Credits = 3},


        };


        public List<Course> GetAllCourse()
        {
            return courses;
        }


        public Course GetById(int id)
        {
            return courses.FirstOrDefault(courses => courses.Id == id);
        }


        public Course? AddCourse(Course course)
        {
            courses.Add(course);
            return course;
        }

        public Course UpdateCourse(int id , Course course)
        {
            var existing = courses.FirstOrDefault(c => c.Id == id);
            if (existing == null)
                return null;
            existing.Duration = course.Duration;
            existing.Credits = course.Credits;
            return existing;
        }

        public bool DeleteCourse(int id)
        {
            var course = courses.FirstOrDefault(course => course.Id == id);
            if (course == null)
                return false;
            courses.Remove(course);
            return true;
        }
        }
}
