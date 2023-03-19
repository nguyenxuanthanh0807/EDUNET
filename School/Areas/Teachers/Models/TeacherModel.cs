using School.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Areas.Teacher.Models
{
    [Table("Teacher")]
    public class TeacherModel
    {
        [Key]
        public string Teacher_Id { get; set; }
        [Required]
        public string Teacher_Name { get; set; }
        public string Teacher_Email { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
