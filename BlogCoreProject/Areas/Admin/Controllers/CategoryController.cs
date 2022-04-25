using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace BlogCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager manager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page=1)
        {
            var categories = manager.AllList().ToPagedList(page,2);
            return View(categories);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            CategoryValidator validRules = new CategoryValidator();
            ValidationResult results = validRules.Validate(category);
            if (ModelState.IsValid)
            {
                category.Status = true;
                manager.AddEntity(category);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
                return View();
            }

        }

        public IActionResult ChangeStatus(int id)
        {
            var category = manager.GetByID(id);
            if (category.Status)
            {
                category.Status = false;
                manager.UpdateEntity(category);
            }
            else
            {
                category.Status = true;
                manager.UpdateEntity(category);
            }
            return RedirectToAction("Index","Category");
        }

        public IActionResult DeleteCategory(int id)
        {
            var category = manager.GetByID(id);
            manager.DeleteEntity(category);
            return RedirectToAction("index", "category");
        }
    }

}
