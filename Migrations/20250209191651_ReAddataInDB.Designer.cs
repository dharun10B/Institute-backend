﻿// <auto-generated />
using Institute_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Institute_Management.Migrations
{
    [DbContext(typeof(InstituteContext))]
    [Migration("20250209191651_ReAddataInDB")]
    partial class ReAddataInDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Institute_Management.Models.AdminModule+Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("UserId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.BatchModule+Batch", b =>
                {
                    b.Property<int>("BatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatchId"));

                    b.Property<string>("BatchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatchTiming")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatchType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("BatchId");

                    b.HasIndex("CourseId");

                    b.ToTable("Batches");

                    b.HasData(
                        new
                        {
                            BatchId = 1,
                            BatchName = "Batch A",
                            BatchTiming = "9:00 AM - 12:00 PM",
                            BatchType = "Full-Time",
                            CourseId = 1
                        },
                        new
                        {
                            BatchId = 2,
                            BatchName = "Batch B",
                            BatchTiming = "2:00 PM - 5:00 PM",
                            BatchType = "Part-Time",
                            CourseId = 2
                        },
                        new
                        {
                            BatchId = 3,
                            BatchName = "Batch C",
                            BatchTiming = "10:00 AM - 1:00 PM",
                            BatchType = "Full-Time",
                            CourseId = 3
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.CourseModule+Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int?>("BatchId")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("BatchId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "Mathematics 101",
                            Description = "Basic Mathematics",
                            TeacherId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Physics 101",
                            Description = "Fundamentals of Physics",
                            TeacherId = 2
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "Advanced Math",
                            Description = "Advanced Topics in Math",
                            TeacherId = 1
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.StudentCourseModule+StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 2
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.StudentModule+Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int?>("BatchId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("BatchId");

                    b.HasIndex("UserId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            BatchId = 1,
                            UserId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            BatchId = 2,
                            UserId = 5
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.TeacherModule+Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("SubjectSpecialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.HasIndex("UserId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            SubjectSpecialization = "Mathematics",
                            UserId = 3
                        },
                        new
                        {
                            TeacherId = 2,
                            SubjectSpecialization = "Physics",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.UserModule+User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("ContactDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ContactDetails = "1234567890",
                            Email = "admin@example.com",
                            Name = "Admin User",
                            Password = "admin123",
                            Role = "Admin"
                        },
                        new
                        {
                            UserId = 2,
                            ContactDetails = "9876543210",
                            Email = "john@example.com",
                            Name = "John Doe",
                            Password = "password123",
                            Role = "Student"
                        },
                        new
                        {
                            UserId = 3,
                            ContactDetails = "5554443333",
                            Email = "jane@example.com",
                            Name = "Jane Smith",
                            Password = "teacher123",
                            Role = "Teacher"
                        },
                        new
                        {
                            UserId = 4,
                            ContactDetails = "6667778888",
                            Email = "mark@example.com",
                            Name = "Mark Johnson",
                            Password = "teacher456",
                            Role = "Teacher"
                        },
                        new
                        {
                            UserId = 5,
                            ContactDetails = "9990001111",
                            Email = "alice@example.com",
                            Name = "Alice Brown",
                            Password = "student123",
                            Role = "Student"
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.AdminModule+Admin", b =>
                {
                    b.HasOne("Institute_Management.Models.UserModule+User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Institute_Management.Models.BatchModule+Batch", b =>
                {
                    b.HasOne("Institute_Management.Models.CourseModule+Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Institute_Management.Models.CourseModule+Course", b =>
                {
                    b.HasOne("Institute_Management.Models.BatchModule+Batch", null)
                        .WithMany("Courses")
                        .HasForeignKey("BatchId");

                    b.HasOne("Institute_Management.Models.TeacherModule+Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Institute_Management.Models.StudentCourseModule+StudentCourse", b =>
                {
                    b.HasOne("Institute_Management.Models.CourseModule+Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Institute_Management.Models.StudentModule+Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Institute_Management.Models.StudentModule+Student", b =>
                {
                    b.HasOne("Institute_Management.Models.BatchModule+Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId");

                    b.HasOne("Institute_Management.Models.UserModule+User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Batch");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Institute_Management.Models.TeacherModule+Teacher", b =>
                {
                    b.HasOne("Institute_Management.Models.UserModule+User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Institute_Management.Models.BatchModule+Batch", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Institute_Management.Models.CourseModule+Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Institute_Management.Models.StudentModule+Student", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Institute_Management.Models.TeacherModule+Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
