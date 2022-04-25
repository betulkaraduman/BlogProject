using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.ViewComponents.Writers
{
    public class WriterNotification:ViewComponent
    {
        NotificationManager manager = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var notifications = manager.AllList();
            return View(notifications);
        }
    }
}
