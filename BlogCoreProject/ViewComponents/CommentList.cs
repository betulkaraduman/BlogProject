using BlogCoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var comments = new List<UserComments>
            {
                new UserComments{Id=1,Username="Betul"},
                new UserComments{Id=4,Username="Betul 1 "},
                new UserComments{Id=2,Username="Betul 2"},
                new UserComments{Id=3,Username="Betul 3"}
            };
            return View(comments);
        }
    }
}
