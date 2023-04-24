using InternetShop.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace InternetShop.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryViewModel categoryViewModel)
        {
            return RedirectToAction("Index");
        }
    }
}
