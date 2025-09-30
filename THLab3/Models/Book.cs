using Microsoft.AspNetCore.Mvc.Rendering;

namespace THLab3.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chu Thuat Hoi Chien E25",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b1.jpg",
                    Price = 104000,
                    Sumary = "",
                    TotalPage = 250
                }, //
                new Book()
                {
                    Id = 2,
                    Title = "Blue Lock E27",
                    AuthorId = 2,
                    GenreId = 2,
                    Image = "/images/products/b2.jpg",
                    Price = 66600,
                    Sumary = "",
                    TotalPage = 200
                }, //
                new Book()
                {
                    Id = 3,
                    Title = "Solo Leveling E3",
                    AuthorId = 3,
                    GenreId = 3,
                    Image = "/images/products/b3.jpg",
                    Price = 154000,
                    Sumary = "",
                    TotalPage = 234
                }, //
                new Book()
                {
                    Id = 4,
                    Title = "Shangri-la Frontier E15",
                    AuthorId = 4,
                    GenreId = 1,
                    Image = "/images/products/b4.jpg",
                    Price = 36000,
                    Sumary = "",
                    TotalPage = 212
                }, //, 
                new Book()
                {
                    Id = 5,
                    Title = "Solo Leveling E5",
                    AuthorId = 3,
                    GenreId = 3,
                    Image = "/images/products/b5.jpg",
                    Price = 154000,
                    Sumary = "",
                    TotalPage = 234
                }, //
            };

            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);

            return book;
        }

        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Gege Akutami"},
            new SelectListItem {Value = "2", Text = "Muneyuki Kaneshiro"},
            new SelectListItem {Value = "3", Text = "Chugong"},
            new SelectListItem {Value = "4", Text = "Katarina, Ryosuke Fuji"},
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Hanh Dong"},
            new SelectListItem {Value = "2", Text = "Chien Thuat"},
            new SelectListItem {Value = "3", Text = "Gia Tuong"}
        };
    }
}
