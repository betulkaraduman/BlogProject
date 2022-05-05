using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.ViewComponents.Writers
{
    public class WriterInfoDashboard : ViewComponent
    {
        WriterManager manager = new WriterManager(new EfWriterRepository());
        private readonly UserManager<AppUser> _userManager;
        public WriterInfoDashboard(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            //var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var username = User.Identity.Name;
            ViewBag.Name = username;
            var userMail = c.Users.Where(i => i.UserName == username).Select(y=>y.Email).FirstOrDefault();
            var WriterId = c.Writers.Where(i => i.Email == userMail).Select(x => x.WriterId).FirstOrDefault();
            var writer = manager.AllList(i=>i.WriterId==WriterId);
            return View(writer);
        }
    }
}
