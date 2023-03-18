using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using School.Areas.Subject.Models;

namespace School.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>()
                .HasKey(c => new { c.SubjectId, c.TeacherId, c.ClassId });

            modelBuilder.Entity<Course>()
                .HasOne(ci => ci.Subject)
                .WithMany(c => c.Courses)
                .HasForeignKey(ci => ci.SubjectId);

            //modelBuilder.Entity<Course>()
            //    .HasOne(ai => ai.Teacher)
            //    .WithMany(a => a.Courses)
            //    .HasForeignKey(ai => ai.TeacherId);

            //modelBuilder.Entity<Course>()
            //    .HasOne(bi => bi.Class)
            //    .WithMany(b => b.Course)
            //    .HasForeignKey(c => c.ClassId);  
            
            //modelBuilder.Entity<Class>()
            //    .HasOne(ci => ci.Student)
            //    .WithMany(c => c.Class) 
            //    .HasForeignKey(o => o.StudentId);
                
        }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<Class> Classes { get; set; }
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}
