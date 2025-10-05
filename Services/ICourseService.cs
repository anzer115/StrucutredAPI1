using StrucutredAPI1.Data;

namespace StrucutredAPI1.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllCourses();

        Task<Course?> CreateCourse(Course course);
        Task<Course?> GetCourseById(int id);
        Task<Course?> UpdateCourse(int id, Course newCourse);
        Task<Course?> DeleteCourse(int id);
    }
}
