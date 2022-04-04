using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.ViewComponents.Categories
{
    public class CategoryListDashboard : ViewComponent
    {
        CategoryManager manager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
           var categories= manager.AllList();
            return View(categories);
        }
    }
}
