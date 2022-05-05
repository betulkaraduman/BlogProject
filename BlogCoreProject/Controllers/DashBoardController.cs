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
            var user = User.Identity.Name;
            var username = User.Identity.Name;
            var userMail = context.Users.Where(i => i.UserName == username).Select(y => y.Email).FirstOrDefault();
            var WriterId = context.Writers.Where(x => x.Email == userMail).Select(i => i.WriterId).FirstOrDefault();
            ViewBag.BlogCount = context.Blogs.Count().ToString();
            ViewBag.CategoryCount = context.Categories.Count().ToString();
            ViewBag.YourBlogCount = context.Blogs.Where(i => i.WriterId == WriterId).Count().ToString();

            return View();
        }
    }
}
