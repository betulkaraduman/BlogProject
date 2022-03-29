using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.ViewComponents.Writer
{
    public class BlogListByWriter:ViewComponent
    {
        BlogManager manager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int WriterId)
        {

            var values = manager.AllBlogsByWriter(WriterId);
            return View(values);
        }
    }
}
