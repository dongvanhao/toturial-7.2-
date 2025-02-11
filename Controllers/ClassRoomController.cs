using BackEnd_6_2_2025_.Model;
using BackEnd_6_2_2025_.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_6_2_2025_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly ClassRoomService _classRoomService;
        public ClassRoomController(ClassRoomService classRoomService)
        {
            _classRoomService = classRoomService;
        }
        [HttpPost]
        public IActionResult AddClassRoom([FromBody] ClassRoomModel classRoom)
        {
            try
            {
                return Ok(_classRoomService.Add(classRoom));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in adding class room");
            }
        }
        [HttpGet]
        public IActionResult GetAllClassRooms()
        {
            try
            {
                return Ok(_classRoomService.GetAll());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in fetching class rooms");
            }
        }
        [HttpGet("students-with-class")]
        public IActionResult GetAllStudentsWithClassInfo()
        {
            var result = _classRoomService.GetAllStudentsWithClassInfo();
            return Ok(result);
        }
        [HttpDelete("delete-class/{id}")]
        public IActionResult DeleteClassRoom(int id)
        {
            var result = _classRoomService.DeleteClassRoom(id);
            if (!result) return NotFound();

            return NoContent();
        }

        [HttpGet("students-with-class-after-delete")]
        public IActionResult GetAllStudentsWithClassInfoAfterDelete()
        {
            var result = _classRoomService.GetAllStudentsWithClassInfoAfterDelete();
            return Ok(result);
        }
    }
}
