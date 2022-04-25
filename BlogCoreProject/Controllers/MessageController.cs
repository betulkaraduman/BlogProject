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
            var user = User.Identity.Name;
            var WriterId = c.Writers.Where(i => i.Email == user).Select(x => x.WriterId).FirstOrDefault();


            var messages = manager.GetListWithMessageByWriter(WriterId);
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
            Writer writer= managerWriter.GetByID(Convert.ToInt32(message.SenderId));
            ViewBag.User = writer.WriterName;
            return View(message);
        }
    }
}
