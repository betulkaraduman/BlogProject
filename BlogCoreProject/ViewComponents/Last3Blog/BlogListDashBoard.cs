using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.ViewComponents.Last3Blog
{
    public class BlogListDashBoard:ViewComponent
    {
        BlogManager manager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var blogList = manager.AllBlogsByWriter(2);
            return View(blogList);
        }


    }
}
