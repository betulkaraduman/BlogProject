using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class WriterController : Controller
    {
        WriterManager maneger = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
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
            var writer = maneger.GetByID(2);
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
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
