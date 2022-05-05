using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class MessageController : Controller
    {
        MessageManager manager = new MessageManager(new EfMessageRepository());
        WriterManager managerWriter = new WriterManager(new EfWriterRepository());
        Context c = new Context();

        public IActionResult Index()
        {
            var messages = manager.GetListWithMessageByWriter(GetWriterId());
            return View(messages);
        }
        public IActionResult SendBox()
        {
            var messages = manager.GetSendBoxListByWriter(GetWriterId());
            return View(messages);
        }
        public IActionResult GetAll()
        {
            return View();
        }


        [HttpGet]
        public IActionResult MessageDetail(int Id)
        {
            var message = manager.GetByID(Id);
            Writer writer = managerWriter.GetByID(Convert.ToInt32(message.SenderId));
            ViewBag.User = writer.WriterName;
            return View(message);
        }


        public IActionResult MessageAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MessageAdd(Message message)
        {
            message.SenderId = GetWriterId();
            message.ReveiverId = 3;
            message.MessageStatus = true;
            message.MessageDate = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            manager.AddEntity(message);
            return RedirectToAction("SendBox");
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
