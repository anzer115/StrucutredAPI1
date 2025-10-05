using StrucutredAPI1.Data;
using StrucutredAPI1.Repositories;

namespace StrucutredAPI1.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;
        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }

        public async Task<Course?> CreateCourse(Course course)
        {
            var createdCourse = await _repository.CreateCourse(course);
            return createdCourse; 
        }

        public async Task<Course?> DeleteCourse(int id)
        {
            var coursetodel = await _repository.GetCourseById(id);
            if (coursetodel == null) return null;
            var delcourse = await _repository.DeleteCourse(coursetodel);
            return delcourse; 
        }

        public async Task<IEnumerable<Course>> GetAllCourses()
        {
            var courses = await _repository.GetAllCourses();
            return courses; 
        }

        public async Task<Course?> GetCourseById(int id)
        {
            var course = await _repository.GetCourseById(id);
            if (course == null) return null;
            return course; 
        }

        public async Task<Course?> UpdateCourse(int id, Course newCourse)
        {
            var courseToUpdate = await _repository.GetCourseById(id);
            if (courseToUpdate == null || newCourse==null || id!=newCourse.C_id) return null;
            courseToUpdate.CourseName = newCourse.CourseName;
            var UpdateCourse = await _repository.UpdateCourse(courseToUpdate);
            return UpdateCourse; 
        }
    }
}
