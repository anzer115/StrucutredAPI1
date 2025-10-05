using StrucutredAPI1.Data;

namespace StrucutredAPI1.Repositories
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAllCourses();

        Task<Course> CreateCourse(Course course);
        Task<Course> GetCourseById(int id);
        Task<Course> UpdateCourse(Course newCourse);
        Task<Course> DeleteCourse(Course delCourse);
    }
}
