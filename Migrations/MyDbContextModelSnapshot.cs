﻿// <auto-generated />
using BackEnd_6_2_2025_.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackEnd_6_2_2025_.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BackEnd_6_2_2025_.Data.ClassRoom", b =>
                {
                    b.Property<int>("ClassRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassRoomId"));

                    b.Property<string>("ClassRoomLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassRoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassRoomId");

                    b.ToTable("ClassRooms");

                    b.HasData(
                        new
                        {
                            ClassRoomId = 1,
                            ClassRoomLocation = "Ha Noi",
                            ClassRoomName = "H1"
                        },
                        new
                        {
                            ClassRoomId = 2,
                            ClassRoomLocation = "Ha Noi",
                            ClassRoomName = "H2"
                        },
                        new
                        {
                            ClassRoomId = 3,
                            ClassRoomLocation = "Ha Noi",
                            ClassRoomName = "H3"
                        });
                });

            modelBuilder.Entity("BackEnd_6_2_2025_.Data.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("ClassRoomId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassRoomId");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            ClassRoomId = 1,
                            StudentName = "A"
                        },
                        new
                        {
                            StudentId = 2,
                            ClassRoomId = 1,
                            StudentName = "B"
                        },
                        new
                        {
                            StudentId = 3,
                            ClassRoomId = 2,
                            StudentName = "C"
                        },
                        new
                        {
                            StudentId = 4,
                            ClassRoomId = 2,
                            StudentName = "D"
                        },
                        new
                        {
                            StudentId = 5,
                            ClassRoomId = 3,
                            StudentName = "E"
                        },
                        new
                        {
                            StudentId = 6,
                            ClassRoomId = 3,
                            StudentName = "F"
                        });
                });

            modelBuilder.Entity("BackEnd_6_2_2025_.Data.Student", b =>
                {
                    b.HasOne("BackEnd_6_2_2025_.Data.ClassRoom", "ClassRoom")
                        .WithMany("Students")
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRoom");
                });

            modelBuilder.Entity("BackEnd_6_2_2025_.Data.ClassRoom", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
