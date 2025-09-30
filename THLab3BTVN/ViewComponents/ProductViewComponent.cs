using Microsoft.AspNetCore.Mvc;
using THLab3BTVN.Models;

namespace THLab3BTVN.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        protected Product product = new Product();
        public IViewComponentResult Invoke()
        {
            var products = product.GetProductList();

            return View(products);
        }
    }
}
