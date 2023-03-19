using School.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Areas.Subject.Models
{
    [Table("Subject")]
    public class SubjectModel
    {
        [Key]
        public string Subject_Id { get; set; }
        [Required]
        public string Subject_Name { get; set; }
        public int Learn_time { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        
    }
}
