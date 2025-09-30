using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using THLab6.Models;

namespace THLab6.Controllers
{
    public class AccountController : Controller
    {
        private static List<Account> _accounts = new List<Account>();

        public IActionResult Index()
        {
            return View(_accounts);
        }

        public IActionResult Create()
        {
            return View(new Account());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Account model)
        {
            if (ModelState.IsValid)
            {
                // Giả sử Id tự tăng
                model.Id = _accounts.Count > 0 ? _accounts.Max(a => a.Id) + 1 : 1;

                _accounts.Add(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPhone(string phone)
        {
            Regex _isPhone = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");

            if (!_isPhone.IsMatch(phone))
            {
                return Json($"Số điện thoại {phone} không đúng định dạng, VD: 0986421127 hoặc 098.421.1127");
            }

            return Json(true);
        }
    }
}
