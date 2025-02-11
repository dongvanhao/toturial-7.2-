namespace BackEnd_6_2_2025_.Model
{
    public class ClassRoomModel
    {
        public string ClassRoomName { get; set; }
        public string ClassRoomLocation { get; set; }
    }
    public class ClassRoomVM : ClassRoomModel
    {
        public int ClassRoomId { get; set; }
    }
}
