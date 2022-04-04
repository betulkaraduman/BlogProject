using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.BlogCount = context.Blogs.Count().ToString();
            ViewBag.CategoryCount = context.Categories.Count().ToString();
            ViewBag.YourBlogCount = context.Blogs.Where(i=>i.WriterId==2).Count().ToString();
            return View();
        }
    }
}
