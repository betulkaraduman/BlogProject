using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4:ViewComponent
    {
        Context context=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.Admin = context.Admins.Where(i => i.AdminId==1).Select(i=>i.Name).FirstOrDefault();
            ViewBag.AdminImage = context.Admins.Where(i => i.AdminId==1).Select(i=>i.ImageUrl).FirstOrDefault();
            ViewBag.Description = context.Admins.Where(i => i.AdminId==1).Select(i=>i.ShortDescription).FirstOrDefault();
            return View();
        }

    }
}
