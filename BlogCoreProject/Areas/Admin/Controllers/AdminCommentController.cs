using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "ADMIN")]
    public class AdminCommentController : Controller
    {
        CommentManager manager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var commentList = manager.GetListWithBlog();
            return View(commentList);
        }
    }
}
