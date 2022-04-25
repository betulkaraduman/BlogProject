using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.About = c.Abouts.FirstOrDefault();
            ViewBag.LastBlog = c.Blogs.OrderByDescending(x=>x.BlogId).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
  
            return View();
        }
    }
}
