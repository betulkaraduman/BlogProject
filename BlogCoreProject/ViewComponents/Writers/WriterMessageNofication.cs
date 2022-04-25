using BusinessLayer.Concrete;
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
        public IViewComponentResult Invoke()
        {

            var messages = manager.GetListWithMessageByWriter(2);
            ViewBag.MessageCount = manager.GetListWithMessageByWriter(2).Count().ToString();
            return View(messages);
        }
    }
}
