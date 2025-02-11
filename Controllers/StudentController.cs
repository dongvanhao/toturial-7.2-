using BackEnd_6_2_2025_.Model;
using BackEnd_6_2_2025_.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_6_2_2025_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;
        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentModel student)
        {
            try {
                return Ok(_studentService.Add(student));

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in adding student");
            }
            
        }
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            try
            {
                return Ok(_studentService.GetAll());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in fetching students");
            }
        }
    }
}
