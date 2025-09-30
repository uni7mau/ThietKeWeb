using Microsoft.AspNetCore.Mvc;
using THLab3.Models;

namespace THLab3.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();

            return View(books);
        }
    }
}
