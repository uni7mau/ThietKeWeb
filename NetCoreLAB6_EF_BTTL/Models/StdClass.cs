using System.ComponentModel.DataAnnotations;

namespace NetCoreLAB6_EF_BTTL.Models
{
    public class StdClass
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ten khong duoc de trong"), StringLength(100)]
        public string ClassName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
