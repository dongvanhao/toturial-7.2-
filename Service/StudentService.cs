using BackEnd_6_2_2025_.Data;
using BackEnd_6_2_2025_.Model;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_6_2_2025_.Service
{
    public class StudentService
    {
        private readonly MyDbContext _context;
        public StudentService(MyDbContext context)
        {
            _context = context;
        }
        public Student Add(StudentModel student)
        {
            var _Student = new Student
            {
                StudentName = student.StudentName,
                ClassRoomId = student.ClassRoomId
            };
            _context.Students.Add(_Student);
            _context.SaveChanges();
            return _Student;
        }
        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }
    }
}
