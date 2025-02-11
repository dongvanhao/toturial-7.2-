using Microsoft.EntityFrameworkCore;

namespace BackEnd_6_2_2025_.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder moreBuilder)
        {
            base.OnModelCreating(moreBuilder);
            moreBuilder.Entity<ClassRoom>().HasData(
                new ClassRoom { ClassRoomId = 1, ClassRoomName = "H1", ClassRoomLocation = "Ha Noi" },
                new ClassRoom { ClassRoomId = 2, ClassRoomName = "H2", ClassRoomLocation = "Ha Noi" },
                new ClassRoom { ClassRoomId = 3, ClassRoomName = "H3", ClassRoomLocation = "Ha Noi" }
            );
            moreBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, StudentName = "A", ClassRoomId = 1 },
                new Student { StudentId = 2, StudentName = "B", ClassRoomId = 1 },
                new Student { StudentId = 3, StudentName = "C", ClassRoomId = 2 },
                new Student { StudentId = 4, StudentName = "D", ClassRoomId = 2 },
                new Student { StudentId = 5, StudentName = "E", ClassRoomId = 3 },
                new Student { StudentId = 6, StudentName = "F", ClassRoomId = 3 }
            );
        }
    }


}
