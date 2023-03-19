using DEMO.Areas.Student.Models;
using School.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEMO.Areas.Student.Models
{
    [Table("Student")]
    public class StudentModel
    {
      
        [Key]
        public string Student_Id { get; set; }
        [Required]
        public string Student_Name { get; set; }
        public string Student_Email { get; set; }
        [Range(1,10,ErrorMessage = "score must be 1 to 10")]
        public int Score { get; set; }
        public string Class_Id { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

    }
}
