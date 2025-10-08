using System.ComponentModel.DataAnnotations;

namespace NetCoreLAB6_EF_BTTL.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ten khong duoc de trong"), StringLength(100)]
        public string SubjectName { get; set; }
        public ICollection<Mark> Marks { get; set; }
    }
}
