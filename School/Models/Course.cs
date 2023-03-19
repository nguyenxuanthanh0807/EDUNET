using School.Areas.Class.Models;
using School.Areas.Subject.Models;
using School.Areas.Teacher.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    [Table("Course")]
    public class Course
    {

        public string Class_Id { get; set; }
        public virtual ClassModel Class { get; set; }
        public string Subject_Id { get; set; }
        public virtual SubjectModel Subject { get; set; }
        public string Teacher_Id { get; set; }
        public virtual TeacherModel Teacher { get; set; }


        public string Id { get; set; }
    }
}
