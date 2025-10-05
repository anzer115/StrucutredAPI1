using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StrucutredAPI1.Data;
using StrucutredAPI1.Services;

namespace StrucutredAPI1.Controllers
{
    [Route("api/course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service; 
        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCourses()
        {
            var courses = await _service.GetAllCourses();
            return Ok(courses);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCourses([FromBody] Course course)
        {
            if (course == null) return BadRequest("Invalid Course");
            var createdCourse = await _service.CreateCourse(course);
            return Ok("Course is created Successfully"); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID([FromRoute] int id)
        {
            var course = await _service.GetCourseById(id);
            if (course == null) return NotFound("Course Not Found");
            return Ok(course);
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateCourse([FromRoute] int id, [FromBody] Course newCourse)
        {
            var coursetoUpdate = await _service.UpdateCourse(id, newCourse);
            if (coursetoUpdate == null) return BadRequest();
            return Ok(coursetoUpdate); 
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCourse([FromRoute] int id)
        {
            var delCourse = await _service.DeleteCourse(id);
            if (delCourse == null) return BadRequest();
            return Ok("Course Deleted"); 
        }
    }
}
