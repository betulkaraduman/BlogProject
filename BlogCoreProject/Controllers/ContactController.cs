using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactManager manager = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact  c)
        {
            c.ContactDate = DateTime.Parse(DateTime.Now.ToLongDateString());
            c.ContactStatus = true;
            manager.AddEntity(c);
            return RedirectToAction("Index","Blog");
        }
    }
}
