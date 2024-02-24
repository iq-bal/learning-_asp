using Microsoft.AspNetCore.Mvc;
using portfolio.Data;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _db; 
        public CategoryController(ApplicationDbContext db) {
            _db = db; 
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
