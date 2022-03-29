using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult FirstError(int ?code)
        {
            return View();
        }
    }
}
