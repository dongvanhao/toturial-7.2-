namespace BackEnd_6_2_2025_.Data
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }
        public string ClassRoomName { get; set; }
        public string ClassRoomLocation { get; set; }
        // 1-n: 1 class co n student
        public ICollection<Student> Students { get; set; }
    }
}
