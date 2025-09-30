using System.ComponentModel.DataAnnotations;

namespace THLab5.Models
{
    public enum Gender
    {
        Male = 1,
        Female = 2,
        Other = 3
    }

    public class Employee
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

        [Required]
        public bool Status { get; set; }  // true = đang làm, false = nghỉ
    }
}
