using Microsoft.AspNetCore.Mvc;

namespace THLab1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
