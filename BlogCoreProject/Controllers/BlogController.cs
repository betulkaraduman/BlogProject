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

        public IActionResult BlogDetails([FromQuery(Name = "BlogId")] int BlogId)
        {
            var blog = manager.GetByID(2);
            return View(blog);
        }

    }
}
