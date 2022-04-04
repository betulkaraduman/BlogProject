using BusinessLayer.Concrete;
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
        public IViewComponentResult Invoke()
        {
            var writer = manager.GetByID(2);
            return View(writer);
        }
    }
}
