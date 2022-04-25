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
    public class WriterInfoDashboard : ViewComponent
    {
        WriterManager manager = new WriterManager(new EfWriterRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var userMail = User.Identity.Name;
            var WriterId = c.Writers.Where(i => i.Email == userMail).Select(x => x.WriterId).FirstOrDefault();
            var writer = manager.GetByID(WriterId);
            return View(writer);
        }
    }
}
