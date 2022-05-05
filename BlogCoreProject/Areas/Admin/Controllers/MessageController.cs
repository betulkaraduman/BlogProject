using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "ADMIN")]
    public class MessageController : Controller
    {
        MessageManager manager = new MessageManager(new EfMessageRepository());
        Context c = new Context();
        public IActionResult Inbox()
        {
            var messages = manager.GetListWithMessageByWriter(GetWriterId());
            return View(messages);
        }
        public IActionResult SendBox()
        {
            var messages = manager.GetSendBoxListByWriter(GetWriterId());
            return View(messages);
        }
        public IActionResult ComposeMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ComposeMessage(Message m)
        {
            m.MessageDate =Convert.ToDateTime(DateTime.Now.ToLongDateString());

            //var ReceiveId = c.Writers.Where(i => i.Email == m.ReceiverUser.Email).Select(x => x.WriterId).FirstOrDefault();
            m.MessageStatus = true;
            m.SenderId = GetWriterId();
            m.ReveiverId = 3;
            manager.AddEntity(m);
            return RedirectToAction("SendBox","Message");
        }



        public int GetWriterId()
        {
            var username = User.Identity.Name;
            var Email = c.Users.Where(i => i.UserName == username).Select(i => i.Email).FirstOrDefault();
            var WriterId = c.Writers.Where(i => i.Email == Email).Select(x => x.WriterId).FirstOrDefault();
            return WriterId;
        }
    }
}
