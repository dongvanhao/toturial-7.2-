using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEnd_6_2_2025_.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    ClassRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassRoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassRoomLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.ClassRoomId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_ClassRooms_ClassRoomId",
                        column: x => x.ClassRoomId,
                        principalTable: "ClassRooms",
                        principalColumn: "ClassRoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "ClassRoomId", "ClassRoomLocation", "ClassRoomName" },
                values: new object[,]
                {
                    { 1, "Ha Noi", "H1" },
                    { 2, "Ha Noi", "H2" },
                    { 3, "Ha Noi", "H3" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "ClassRoomId", "StudentName" },
                values: new object[,]
                {
                    { 1, 1, "A" },
                    { 2, 1, "B" },
                    { 3, 2, "C" },
                    { 4, 2, "D" },
                    { 5, 3, "E" },
                    { 6, 3, "F" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassRoomId",
                table: "Student",
                column: "ClassRoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "ClassRooms");
        }
    }
}
