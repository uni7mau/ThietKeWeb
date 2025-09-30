using Microsoft.AspNetCore.Mvc;
using THLab3BTVN.Models;

namespace THLab3BTVN.Controllers
{
    public class ProductController : Controller
    {
        protected Product product = new Product();
        public IActionResult Index()
        {
            var products = product.GetProductList();

            return View(products);
        }

        public PartialViewResult _PartialMenu()
        {
            var products = product.GetProductList();

            return PartialView(products);
        }
    }
}
