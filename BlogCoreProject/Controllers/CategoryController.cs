using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _manager = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = _manager.AllList();
            return View(values);
        }
    }
}
