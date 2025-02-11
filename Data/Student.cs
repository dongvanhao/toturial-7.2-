using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd_6_2_2025_.Data
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        //Khoa Ngoai
       public int ClassRoomId { get; set; }
        [ForeignKey("ClassRoomId")]
        public ClassRoom ClassRoom { get; set; }
    }
}
