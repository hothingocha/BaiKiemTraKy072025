using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}