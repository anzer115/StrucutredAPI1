using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StrucutredAPI1.Data;
using StrucutredAPI1.DTOs;

namespace StrucutredAPI1.Controllers
{
    [Route("api/get")]
    [ApiController]
    public class StudentCourseController(AppDbContext _context) : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var students = await _context.StudentCourses.Include(x => x.Student).Include(y=>y.Course).ToListAsync();
            List<StudentCourseDTO> dtos = new List<StudentCourseDTO>(); 
            foreach (var student in students)
            {
                var dto = new StudentCourseDTO()
                {
                    StudentName = student.Student.Name,
                    CourseName = student.Course.CourseName
                };

                dtos.Add(dto);

            }
            return Ok(dtos); 
        }
    }
}
