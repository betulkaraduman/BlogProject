using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.ViewComponents.Writers
{
    public class WriterMessageNofication:ViewComponent
    {
        MessageManager manager = new MessageManager(new EfMessageRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var Email = c.Users.Where(i => i.UserName == username).Select(i => i.Email).FirstOrDefault();
            var WriterId = c.Writers.Where(i => i.Email == Email).Select(x => x.WriterId).FirstOrDefault();
            var messages = manager.GetListWithMessageByWriter(WriterId);
            ViewBag.MessageCount = manager.GetListWithMessageByWriter(2).Count().ToString();
            return View(messages);
        }
    }
}
