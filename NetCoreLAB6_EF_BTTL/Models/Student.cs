using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreLAB6_EF_BTTL.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ten khong duoc de trong"), StringLength(100)]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Email khong duoc de trong"), StringLength(100)]
        [EmailAddress]
        public string StudentEmail { get; set; }
        [Required(ErrorMessage = "Sdt khong duoc de trong"), StringLength(50)]
        public string StudentPhone { get; set; }
        [Required(ErrorMessage = "Dia chi khong duoc de trong"), StringLength(150)]
        public string StudentAddress { get; set; }
        [StringLength(100)]
        public string StudentAvatar { get; set; }
        [DataType(DataType.Date)]
        public DateTime StudentBirthday { get; set; }

        [ForeignKey("StdClass")]
        public int ClassId { get; set; }
        public StdClass StdClass { get; set; }
        public ICollection<Mark> Marks { get; set; }
    }
}
