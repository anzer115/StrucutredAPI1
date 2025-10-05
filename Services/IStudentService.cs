using StrucutredAPI1.Data;

namespace StrucutredAPI1.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student?> CreateStudent(Student student);
        Task<Student?> GetStudentById(int id);
        Task<Student?> UpdateStudent(int id, Student newStudent);
        Task<Student?> DeleteStudent(int id);
    }
}
