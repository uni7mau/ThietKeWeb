using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace THLab7.Models
{
    [Table("KhoaHoc")]
    public class Course
    {
        [Key]
        [Column("MaKH")]
        public int Id { get; set; }
        [Column("TenKH")]
        public String name { get; set; }
        [Column("HocPhi")]
        public double UnitPrice { get; set; }
    }
}
