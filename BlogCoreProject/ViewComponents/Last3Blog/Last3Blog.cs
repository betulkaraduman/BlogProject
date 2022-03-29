using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.ViewComponents.Last3Blog
{
    public class Last3Blog:ViewComponent
    {
        BlogManager manager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
          var values= manager.Last3Blog();
            return View(values);
        }
    }
}
