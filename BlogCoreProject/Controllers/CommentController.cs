using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager manager = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddCommnet()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
          var values=  manager.GetCommentsByBlogId(2);
            return PartialView(values);
        }
    }
}
