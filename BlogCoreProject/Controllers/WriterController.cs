using BlogCoreProject.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        AppUserManager userManager = new AppUserManager(new EfAppUserRepository());
        private readonly UserManager<AppUser> _userManager;
        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
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
        public async Task<IActionResult> WriterEditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var id = c.Users.Where(i => i.UserName == values.UserName).Select(i => i.Id).FirstOrDefault();
            var result = userManager.GetByID(id);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.Namesurname = result.NameSurname;
            model.Email = result.Email;
            model.imageUrl = result.ImageUrl;
            model.Username = result.UserName;
            return View(model);



        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.NameSurname = model.Namesurname;
            user.Email = model.Email;
            user.ImageUrl = model.imageUrl;
            user.UserName = model.Username;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.password);
            var result = await _userManager.UpdateAsync(user);
            return RedirectToAction("Index", "Dashboard");

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
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/" + newImageName);
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
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
