using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogCoreProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager manager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var blogs = manager.AllBlogsWithCategory();
            return View(blogs);
        }


        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var blog = manager.GetAllBlogById(id);
            return View(blog);
        }
    }
}
