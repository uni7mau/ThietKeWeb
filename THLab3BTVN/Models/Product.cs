using Microsoft.AspNetCore.Mvc.Rendering;

namespace THLab3BTVN.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TypeId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public string Sumary { get; set; }

        public List<Product> GetProductList()
        {
            List<Product> Products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Title = "Noi com dien Komi A123",
                    TypeId = 1,
                    Image = "/images/products/noicomdien.jpg",
                    Price = 104000,
                    Sumary = ""
                }, //
                new Product()
                {
                    Id = 2,
                    Title = "Noi com dien Komi A123",
                    TypeId = 1,
                    Image = "/images/products/noicomdien.jpg",
                    Price = 66600,
                    Sumary = ""
                }, //
                new Product()
                {
                    Id = 3,
                    Title = "Noi com dien Komi A123",
                    TypeId = 1,
                    Image = "/images/products/noicomdien.jpg",
                    Price = 154000,
                    Sumary = "",
                }
            };

            return Products;
        }

    }
}
