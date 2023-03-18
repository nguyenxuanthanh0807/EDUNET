using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Areas.Student.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Score { get; set; }
        public int ClassId { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
        // đứng từ employee lấy danh sách từ departments (optional)
        /*public virtual Class? Class { get; set; }
        public virtual Teachers Teachers {*/
    }
}
