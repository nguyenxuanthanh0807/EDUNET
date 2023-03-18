using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using School.Areas.Subject.Models;

namespace School.Models
{
    public class Course
    {
        public int CourseId { get; set; } 
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }    
        public int TeacherId { get; set; }
        //public virtual teacher teacher { get; set; }
        public int ClassId { get; set; }
        //public virtual Class Class { get; set; }
    }
}
