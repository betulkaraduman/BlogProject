using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager manager = new NewsLetterManager(new EfNewlLetterRepository());
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter nL)
        {
            nL.MailStatus = true;
            manager.AddEntity(nL);
            return PartialView();
        }
    }
}
