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
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Salary { get; set; }
        public int No { get; set; }
        // đứng từ employee lấy danh sách từ departments (optional)
        public virtual Departments? Departments { get; set; }
    }
}
