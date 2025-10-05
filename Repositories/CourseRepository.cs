using Microsoft.EntityFrameworkCore;
using StrucutredAPI1.Data;

namespace StrucutredAPI1.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _context;

        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Course> CreateCourse(Course course)
        {
            var createdcourse = _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return createdcourse.Entity;
        }

        public async Task<Course> DeleteCourse(Course delCourse)
        {
            var todel = _context.Courses.Remove(delCourse);
            await _context.SaveChangesAsync();
            return todel.Entity;
        }

        public async Task<IEnumerable<Course>> GetAllCourses()
        {
            var courses = await _context.Courses.ToListAsync();
            if (courses == null) return new List<Course>();
            return courses;
        }

        public async Task<Course> GetCourseById(int id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(x => x.C_id == id);
            if (course == null) return null;
            return course; 
        }

        public async Task<Course> UpdateCourse(Course newCourse)
        {
            var UpdatedCourse = _context.Courses.Update(newCourse);
            await _context.SaveChangesAsync();
            return UpdatedCourse.Entity; 
        }
    }
}
