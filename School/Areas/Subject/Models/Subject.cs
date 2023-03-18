using School.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Areas.Subject.Models
{
    [Table("Subject")]
    public class Subject { 
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }
        [Required]
        [StringLength(50)]
        public string NameSubject { get; set; }
        public DateTime LearnTime { get; set; }

        public string? PhotoSubject { get; set; }
        public virtual ICollection<Course> Courses { get; set; }



    }
}
