using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreLAB6_EF.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ten san pham khong duoc de trong")]
        [StringLength(150, ErrorMessage = "Ten san pham gioi han 150 ky tu")]
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Gia san pham khong duoc de trong")]
        public float Price { get; set; }
        public float SalePrice { get; set; }
        public byte Status { get; set; }
        [StringLength(1000, ErrorMessage = "Noi dung mo ta gioi han 1000 ky tu")]
        [Column(TypeName = "ntext")]
        public string Descriptions { get; set; }
        [Required(ErrorMessage = "Danh muc san pham khong duoc de trong")]
        public int CategoryId { get; set; }
        public DateTime CreatedTime { get; set; }
        public Category Category { get; set; }
    }
}
