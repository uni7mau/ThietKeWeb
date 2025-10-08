using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreLAB6_EF_BTTL.Models
{
    public class Mark
    {
        [Key, Column(Order = 0)]
        public int SubjectId { get; set; }
        [Key, Column(Order = 1)]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Diem khong duoc de trong")]
        public float Score { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}
