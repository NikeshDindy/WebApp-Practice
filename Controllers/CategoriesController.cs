using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var getListCategory = CategoriesRepository.GetCategories();
            return View(getListCategory);
        }

        public IActionResult Edit(int id)
        {
            //if (id.HasValue)
            //{
            //    return new ContentResult { Content = id.ToString() };
            //}
            //else
            //{
            //    return new ContentResult { Content = "null content" };
            //}

            
            
                var category = CategoriesRepository.GetCategoryById(id);
                return View(category);
            

            return null;
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            CategoriesRepository.UpdateCategoryById(category.Id, category);
            return RedirectToAction("Index");
        }
    }
}
