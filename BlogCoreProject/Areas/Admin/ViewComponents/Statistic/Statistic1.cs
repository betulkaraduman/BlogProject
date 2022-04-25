using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlogCoreProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager manager = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.BlogCount = manager.AllList().Count();
            ViewBag.MessageCount = c.Messages.Count();
            ViewBag.CommentCount = c.Comments.Count();
            string api = "80896d3b5182fd8532ced7f0632f0a2d";
            string connection = $"https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid={api}";
            XDocument documnet = XDocument.Load(connection);
            ViewBag.temperature = documnet.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
