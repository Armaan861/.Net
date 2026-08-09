using _8_Aug_2026.Data;
using _8_Aug_2026.Models;
using _8_Aug_2026.Repository;

namespace _8_Aug_2026.Services
{
    public class CourseService : ICourseService
    {
        private readonly AppDbContext context;
        public CourseService(AppDbContext context)
        {
            this.context = context;
        }
         
        public List<Course> GetCourses()
        {
            return context.Courses.ToList();
        }

        public Course AddCourse(Course course) 
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return course;
        }

        public Course UpdateCourse(int id, Course course)
        {
            var existing = context.Courses.Find(id);
            if (existing != null)
            {
                context.Entry(existing).CurrentValues.SetValues(course);
                context.SaveChanges();
            }
            return existing;
        }

        public Course DeleteCourse(int id )
        {
            var course = context.Courses.Find(id);
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
            }
            return course;

        }


    }
    }

