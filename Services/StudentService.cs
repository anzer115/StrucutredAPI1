using StrucutredAPI1.Data;
using StrucutredAPI1.Repositories;

namespace StrucutredAPI1.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<Student?> CreateStudent(Student student)
        {
            if (student == null) return null;
            var createdStudent = await _repository.CreateStudent(student);
            return createdStudent; 
        }

        public async Task<Student?> DeleteStudent(int id)
        {
            var delStudent = await _repository.GetStudentById(id); 
            if (delStudent == null) return null;
            var deletedStudent = await _repository.DeleteStudent(delStudent);
            return deletedStudent; 
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            var students = await _repository.GetAllStudents();
            return students; 
        }

        public async Task<Student?> GetStudentById(int id)
        {
            var student = await _repository.GetStudentById(id);
            if (student == null) return null;
            return student; 
        }

        public async Task<Student?> UpdateStudent(int id, Student newStudent)
        {
            var UpdatedStudent = await _repository.GetStudentById(id);
            if (id != newStudent.StudentId || newStudent == null) return null;
            UpdatedStudent.Name = newStudent.Name;
            UpdatedStudent.age = newStudent.age;
            var ans = await _repository.UpdateStudent(UpdatedStudent);
            return ans; 
        }
    }
}
