
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "ADMIN")]
    public class AdminBlogController : Controller
    {
        BlogManager manager = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var blogList = manager.AllBlogsByWriter(GetWriterId());
            return View(blogList);
        }
        public int GetWriterId()
        {
            var username = User.Identity.Name;
            var Email = c.Users.Where(i => i.UserName == username).Select(i => i.Email).FirstOrDefault();
            var WriterId = c.Writers.Where(i => i.Email == Email).Select(x => x.WriterId).FirstOrDefault();
            return WriterId;
        }
    }
}
