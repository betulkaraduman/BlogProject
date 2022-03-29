using BlogCoreProject.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager manager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Writer w)
        {
            WriterValidation validRules = new WriterValidation();
            ValidationResult results = validRules.Validate(w);
            if (results.IsValid)
            {
                manager.AddEntity(w);
                return RedirectToAction("Index", "Blog");
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
    }
    //[HttpPost]
    //public IActionResult Index(RegisterViewModel wm)
    //{

    //    if (wm.Password.Equals(wm.ConfirmPasword))
    //    {
    //        wm.WriterStatus = true;
    //        wm.WriterAbout = "Test";
    //        Writer w = new Writer
    //        {
    //            WriterName = wm.WriterName,
    //            WriterAbout = wm.WriterAbout,
    //            WriterImage = wm.WriterImage,
    //            WriterStatus = wm.WriterStatus,
    //            Email=wm.Email,
    //            Password=wm.Password
    //        };

    //        WriterValidation validRules = new WriterValidation();
    //        ValidationResult results = validRules.Validate(w);
    //        if (results.IsValid)
    //        {
    //            manager.AddEntity(w);
    //            return RedirectToAction("Index","Blog");
    //        }
    //        else
    //        {
    //            foreach (var item in results.Errors)
    //            {
    //                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
    //            }
    //            return View();
    //        }
    //    }

    //    return View();
    //}
}

