using BlogCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }

        public IActionResult GetWriterById(int WriterId)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == WriterId);
            var JsonWriter = JsonConvert.SerializeObject(findWriter);
            return Json(JsonWriter);
        }

        public IActionResult DeleteWriter(int WriterId)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == WriterId);
            writers.Remove(findWriter);
            return Json(writers);
        }


        public IActionResult UpdateWriter(WriterClass writerClass)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == writerClass.Id);
            findWriter.Name = writerClass.Name;
            var jsonWriter = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriter);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass{Id=1,Name="Name 1"},
            new WriterClass{Id=2,Name="Name 2"},
            new WriterClass{Id=3,Name="Name 3"},
            new WriterClass{Id=4,Name="Name 4"},
            new WriterClass{Id=5,Name="Name 5"},
        };

        [HttpPost]
        public IActionResult AddWriter(WriterClass c)
        {
            writers.Add(c);
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }
    }
}
