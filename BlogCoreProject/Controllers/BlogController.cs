using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogCoreProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager manager = new BlogManager(new EfBlogRepository());
        private readonly UserManager<AppUser> _userManager;
        public BlogController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        Context c = new Context();
        [AllowAnonymous]
        public IActionResult Index() 
        {
            var blogs = manager.AllBlogsWithCategory();
            return View(blogs);
        }
        [AllowAnonymous]
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var blog = manager.GetAllBlogById(id);
            var firstBlog = manager.GetByID(id);
            ViewBag.WriterId = firstBlog.WriterId;
            return View(blog);
        }

        public IActionResult BlogListByWriter()
        {
            var blogs = manager.AllBlogsByWriter(GetWriterId());
            return View(blogs);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {

            CategoryManager managerCategory = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryValues = (from x in managerCategory.AllList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.categories = categoryValues;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            BlogValidator validRules = new BlogValidator();
            ValidationResult results = validRules.Validate(blog);
            if (results.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                blog.WriterId = GetWriterId();
                manager.AddEntity(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
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
        [HttpPost]
        public IActionResult BlogDelete(int BlogId)
        {
            var blog = manager.GetByID(BlogId);
            manager.DeleteEntity(blog);
            return RedirectToAction("BlogListByWriter", "Blog");
        }

        [HttpGet]
        public IActionResult BlogUpdate(int Id)
        {
            CategoryManager managerCategory = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryValues = (from x in managerCategory.AllList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.categories = categoryValues;
            var blog = manager.GetByID(Id);
            return View(blog);
        }
        [HttpPost]
        public IActionResult BlogUpdate(Blog blog)
        {

            BlogValidator validRules = new BlogValidator();
            ValidationResult results = validRules.Validate(blog);
            if (results.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = Convert.ToDateTime(blog.BlogCreateDate);
                blog.WriterId = GetWriterId();
                manager.UpdateEntity(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
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

        public int GetWriterId()
        {
            var username = User.Identity.Name;
            var Email = c.Users.Where(i => i.UserName == username).Select(i => i.Email).FirstOrDefault();

            var WriterId = c.Writers.Where(i => i.Email == Email).Select(x => x.WriterId).FirstOrDefault();
            return WriterId;
        }
    }
}

