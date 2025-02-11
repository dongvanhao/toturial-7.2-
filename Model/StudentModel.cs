namespace BackEnd_6_2_2025_.Model
{
    public class StudentModel
    {
        public string StudentName { get; set; }
        public int ClassRoomId { get; set; }
    }
    public class StudentVM: StudentModel
    {
        public int StudentId { get; set; }
        
    }
}
