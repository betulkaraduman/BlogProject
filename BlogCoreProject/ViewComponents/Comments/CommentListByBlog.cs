using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.ViewComponents.Comments
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager manager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
          var values=  manager.GetCommentsByBlogId(id);
            return View(values);
        }
    }
}
