using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogCoreProject.Controllers
{

    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer w)
        {

            Context c = new Context();
            var data = c.Writers.FirstOrDefault(x => x.Email == w.Email && x.Password == w.Password);
            if (data is not null)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,w.Email)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal cp = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(cp);

                return RedirectToAction("Index", "Writer");

            }
            else
            {
                return View();
            }


            //Context c = new Context();
            //var data = c.Writers.FirstOrDefault(x => x.Email == w.Email && x.Password == w.Password);
            //if(data is not null)
            //{
            //    HttpContext.Session.SetString("username", w.Email);
            //    return RedirectToAction("Index", "Writer");
            //}
            //else
            //{
            //    return View();
            //}
        }
    }
}
