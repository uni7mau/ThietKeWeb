using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.ComponentModel.DataAnnotations;

namespace THLab7.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Khong duoc de trong")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Khong duoc de trong")]
        public string NameVN { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
