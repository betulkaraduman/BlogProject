using BlogCoreProject.Areas.Admin.Models;
using BusinessLayer.Concrete;
using ClosedXML.Excel;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "ADMIN")]
    public class BlogController : Controller
    {
        BlogManager manager = new BlogManager(new EfBlogRepository());

        public IActionResult ExportStaticExcelBlogList()
        {

            using(var workBook=new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Blog List");
                workSheet.Cell(1, 1).Value = "Blog ID";
                workSheet.Cell(1, 2).Value = "Blog Name";

                int blogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    workSheet.Cell(blogRowCount, 1).Value = item.Id;
                    workSheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }
                using(var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","Works.xlsx");
                }
            }

        }
        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>();
            List<Blog> blogs = new List<Blog>();
            blogs = manager.AllList();
            foreach (var item in blogs)
            {
                bm.Add(new BlogModel { BlogName = item.BlogTitle, Id = item.BlogId });
            }

            return bm;

        }

        public IActionResult BlogListToExcel()
        {
            return View();
        }
    }
}
