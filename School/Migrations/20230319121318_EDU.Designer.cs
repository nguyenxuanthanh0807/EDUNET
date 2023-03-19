﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Models;

#nullable disable

namespace School.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230319121318_EDU")]
    partial class EDU
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("School.Areas.Class.Models.ClassModel", b =>
                {
                    b.Property<string>("Class_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Class_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Class_Id");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("School.Areas.Student.Models.StudentModel", b =>
                {
                    b.Property<string>("Student_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Class_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("Student_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_Id");

                    b.HasIndex("Class_Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("School.Areas.Subject.Models.SubjectModel", b =>
                {
                    b.Property<string>("Subject_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Learn_time")
                        .HasColumnType("int");

                    b.Property<string>("Subject_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Subject_Id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("School.Areas.Teacher.Models.TeacherModel", b =>
                {
                    b.Property<string>("Teacher_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Teacher_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Teacher_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Teacher_Id");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("School.Models.Course", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Class_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Subject_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Teacher_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Class_Id");

                    b.HasIndex("Subject_Id");

                    b.HasIndex("Teacher_Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("School.Areas.Student.Models.StudentModel", b =>
                {
                    b.HasOne("School.Areas.Class.Models.ClassModel", "Class")
                        .WithMany("Students")
                        .HasForeignKey("Class_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("School.Models.Course", b =>
                {
                    b.HasOne("School.Areas.Class.Models.ClassModel", "Class")
                        .WithMany("Courses")
                        .HasForeignKey("Class_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Areas.Subject.Models.SubjectModel", "Subject")
                        .WithMany("Courses")
                        .HasForeignKey("Subject_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Areas.Teacher.Models.TeacherModel", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("Teacher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("School.Areas.Class.Models.ClassModel", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("School.Areas.Subject.Models.SubjectModel", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("School.Areas.Teacher.Models.TeacherModel", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
