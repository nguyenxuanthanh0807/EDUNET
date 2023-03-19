using School.Areas.Student.Models;
using School.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Areas.Class.Models
{
    [Table("Class")]
    public class ClassModel
    {
        [Key]
        public string Class_Id { get; set; }
        [Required]
        public string Class_Name { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<StudentModel> Students { get; set; }

    }
}
