using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using teste.Models;
using teste.Data;

namespace teste.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepo _repo;
        public CategoryController(ICategoryRepo repo)
        {
            _repo = repo;
        }
        public ActionResult<IEnumerable<Category>> Index()
        {
            var data = _repo.GetAll();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult<Category> Create(Category cat)
        {
            if (ModelState.IsValid)
            {
                _repo.Create(cat);
                var repo = _repo.Get(cat.Id);
                if (repo == cat) return RedirectToAction("Index");
                else return StatusCode(500);
            }
            return View();
        }
        [HttpGet]
        public ActionResult<Category> Edit(int id)
        {
            var cat = _repo.Get(id);
            return View(cat);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category cat)
        {
            _repo.Update(cat);
            var repo = _repo.Get(cat.Id);
            if (repo != cat) { throw new System.Exception(); }

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var cat = _repo.Get(id);
            return View(cat);
        }
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}