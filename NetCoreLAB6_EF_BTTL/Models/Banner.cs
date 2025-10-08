using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreLAB6_EF_BTTL.Models
{
    [Table("Banner")]
    public class Banner
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "Khong duoc de trong ten")]
        public string Name { get; set; }
        public string Image { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public byte Status { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
