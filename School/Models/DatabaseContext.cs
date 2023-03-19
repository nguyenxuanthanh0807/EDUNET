using School.Areas.Class.Models;
using School.Areas.Student.Models;
using School.Areas.Subject.Models;
using School.Areas.Teacher.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using DEMO.Areas.Student.Models;

namespace School.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<Course>()
            //.HasKey(oi => new { oi.Class_Id, oi.Subject_Id, oi.Teacher_Id });

            modelBuilder.Entity<Course>(entity => 
            {
                    entity.HasOne(oi => oi.Class).WithMany(o => o.Courses)
                    .HasForeignKey(oi => oi.Class_Id);
                 
                    entity.HasOne(oi => oi.Subject).WithMany(p => p.Courses)
                    .HasForeignKey(p => p.Subject_Id);

                   
                    entity.HasOne(oi => oi.Teacher).WithMany(p => p.Courses)
                    .HasForeignKey(p => p.Teacher_Id);

                });
               

   

            modelBuilder.Entity<StudentModel>()
                .HasOne(o => o.Class_Id)
                .WithMany(c => c.Student)
                .HasForeignKey(o => o.Class_Id);
        }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<SubjectModel> Subjects { get; set; }
        public DbSet<ClassModel> Classes { get; set; }
        public DbSet<TeacherModel> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
