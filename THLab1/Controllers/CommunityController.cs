using Microsoft.AspNetCore.Mvc;

namespace THLab1.Controllers
{
    public class CommunityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Forums() => View();
        public IActionResult Guides() => View();
        public IActionResult Events() => View();
    }
}
