using BackEnd_6_2_2025_.Data;
using BackEnd_6_2_2025_.Model;

namespace BackEnd_6_2_2025_.Service
{
    public class ClassRoomService
    {
        public readonly MyDbContext _context;
        public ClassRoomService(MyDbContext context)
        {
            _context = context;
        }
        public ClassRoom Add(ClassRoomModel classRoom)
        {
            var _ClassRoom = new ClassRoom
            {
                ClassRoomName = classRoom.ClassRoomName,
                ClassRoomLocation = classRoom.ClassRoomLocation
            };
            _context.ClassRooms.Add(_ClassRoom);
            _context.SaveChanges();
            return _ClassRoom;
        }
        public List<ClassRoom> GetAll()
        {
            return _context.ClassRooms.ToList();
        }
        public List<object> GetAllStudentsWithClassInfo()
        {
            var result = (from student in _context.Students
                          join classRoom in _context.ClassRooms
                          on student.ClassRoomId equals classRoom.ClassRoomId
                          select new
                          {
                              student.StudentId,
                              student.StudentName,
                              classRoom.ClassRoomId,
                              classRoom.ClassRoomName,
                              classRoom.ClassRoomLocation
                          }).ToList();

            return result.Cast<object>().ToList();
        }
        public bool DeleteClassRoom(int classRoomId)
        {
            var classRoom = _context.ClassRooms.Find(classRoomId);
            if (classRoom == null) return false;

            _context.ClassRooms.Remove(classRoom);
            _context.SaveChanges();
            return true;
        }
        public List<object> GetAllStudentsWithClassInfoAfterDelete()
        {
            var result = (from student in _context.Students
                          join classRoom in _context.ClassRooms
                          on student.ClassRoomId equals classRoom.ClassRoomId into studentClassRoomGroup
                          from classRoom in studentClassRoomGroup.DefaultIfEmpty() // Left Join
                          select new
                          {
                              student.StudentId,
                              student.StudentName,
                              ClassRoomId = classRoom != null ? classRoom.ClassRoomId : (int?)null, // Handle null propagation manually
                              ClassRoomName = classRoom != null ? classRoom.ClassRoomName : null,
                              ClassRoomLocation = classRoom != null ? classRoom.ClassRoomLocation : null
                          }).ToList();

            return result.Cast<object>().ToList();
        }

    }
}
