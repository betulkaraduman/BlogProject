using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class AboutController : Controller
    {
        AboutManager manager = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values = manager.AllList();
            return View(values);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
        public PartialViewResult RecentPosts()
        {
            return PartialView();
        }
    }
}
