using Microsoft.EntityFrameworkCore;
using StrucutredAPI1.Data;

namespace StrucutredAPI1.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context; 

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Student> CreateStudent(Student student)
        {
            var createdstudent =  _context.Students.Add(student);
            await _context.SaveChangesAsync(); 
            return createdstudent.Entity;
        }

        public async  Task<Student> DeleteStudent(Student delStudent)
        {
            var todel = _context.Students.Remove(delStudent);
            await _context.SaveChangesAsync();
            return todel.Entity; 
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            var students = await _context.Students.ToListAsync();
            if (students == null) return new List<Student>();
            return students; 
        }

        public async Task<Student> GetStudentById(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return null;
            return student; 
        }

        public async Task<Student> UpdateStudent(Student newStudent)
        {
            var Update = _context.Students.Update(newStudent);
            await _context.SaveChangesAsync(); 
            return Update.Entity; 
        }
    }
}
