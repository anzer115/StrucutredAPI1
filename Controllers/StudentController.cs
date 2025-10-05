using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StrucutredAPI1.Data;
using StrucutredAPI1.Services;

namespace StrucutredAPI1.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service; 
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _service.GetAllStudents();
            if (students == null) return NotFound();
            return Ok(students); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById([FromRoute] int id)
        {
            var student = await _service.GetStudentById(id);
            if (student == null) return NotFound("Invalid Id");
            return Ok(student); 
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateStudent([FromBody] Student student)
        {
            var createdStudent = await _service.CreateStudent(student);
            return Ok(createdStudent); 
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update([FromRoute] int id,[FromBody] Student student)
        {
            var UpdateStudent = await _service.UpdateStudent(id,student);
            if (UpdateStudent == null) return BadRequest("Something Broke");
            return Ok(UpdateStudent);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] int id)
        {
            var DelStudent = await _service.DeleteStudent(id);
            if (DelStudent == null) return BadRequest("Something Broke");
            return Ok("Student Deleted Success!");
        }

    }
}
