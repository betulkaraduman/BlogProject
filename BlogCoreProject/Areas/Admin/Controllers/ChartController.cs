using BlogCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> categoryClasses = new List<CategoryClass>();
            categoryClasses.Add(new CategoryClass() { CategoryName = "Technology", CategoryCount = 15 });
            categoryClasses.Add(new CategoryClass() { CategoryName = "Sport", CategoryCount = 10 });
            categoryClasses.Add(new CategoryClass() { CategoryName = "Software", CategoryCount = 5 });


            return Json(new {jsonList=categoryClasses});
        }
    }
}
