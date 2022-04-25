using BlogCoreProject.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class WriterController : Controller
    {
        WriterManager maneger = new WriterManager(new EfWriterRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var user = User.Identity.Name;
          
            var WriterName = c.Writers.Where(i => i.Email == user).Select(x => x.WriterName).FirstOrDefault();
            ViewBag.ActiveUser = WriterName;
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public IActionResult WriterEditProfile()
        {
            var user = User.Identity.Name;
            var WriterId = c.Writers.Where(i => i.Email == user).Select(x => x.WriterId).FirstOrDefault();

            var writer = maneger.GetByID(WriterId);
            return View(writer);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidation validRules = new WriterValidation();
            ValidationResult results = validRules.Validate(writer);
            if (results.IsValid)
            {

                maneger.UpdateEntity(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        [AllowAnonymous]
        public IActionResult WriterAdd()
        {
            AddProfileImage writer = new AddProfileImage();
            return View(writer);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage w)
        {
            Writer wr = new Writer();
            if (w.WriterImage != null)
            {
                var extension = Path.GetExtension(w.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/" +newImageName );
                var stream = new FileStream(location, FileMode.Create);
                w.WriterImage.CopyTo(stream);
                wr.WriterImage = newImageName;
            }
            wr.Email = w.Email;
            wr.Password = w.Password;
            wr.ConfirmPassword = w.ConfirmPassword;
            wr.WriterAbout = w.WriterAbout;
            wr.WriterName = w.WriterName;
            wr.WriterStatus = w.WriterStatus;
             maneger.AddEntity(wr);
            return RedirectToAction("Index","Dashboard");
        }
    }
}
