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
        public ActionResult<Category> Create(Category cat)
        {
            return View(_repo.Create(cat));
        }
        public ActionResult<Category> Get(int id)
        {
            return View(_repo.Get(id));
        }
    }
}