using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using THLab7.Models;

namespace THLab7.Controllers
{
    public class CategoryController : Controller
    {
        private readonly EShopV10 _db;

        public CategoryController(EShopV10 context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var list = _db.Categories.ToList();
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            var category = _db.Categories.Find(id);
            _db.Categories.Remove(category);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _db.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _db.Categories.Update(category);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
