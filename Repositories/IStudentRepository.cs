using StrucutredAPI1.Data;

namespace StrucutredAPI1.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudents();

        Task<Student> CreateStudent(Student student); 
        Task<Student> GetStudentById(int id);
        Task<Student> UpdateStudent(Student newStudent);
        Task<Student> DeleteStudent(Student delStudent); 
    }
}
