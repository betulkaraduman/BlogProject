using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager manager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer w)
        {
            manager.AddEntity()
            return View();
        }
    }
}
