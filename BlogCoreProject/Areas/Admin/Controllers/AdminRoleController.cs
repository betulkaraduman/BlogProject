using BlogCoreProject.Areas.Admin.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="ADMIN")]
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<AppRole> _manager;
        private readonly UserManager<AppUser> _userManager;
        public AdminRoleController(RoleManager<AppRole> manager, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _manager = manager;
        }

        public IActionResult Index()
        {
            var roles = _manager.Roles.ToList();
            return View(roles);
        }

        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppRole role = new AppRole
                {
                    Name = model.RoleName
                };
                var result = await _manager.CreateAsync(role);
                if (result.Succeeded)
                {

                    return RedirectToAction("/Admin/AdminRole/Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values = _manager.Roles.FirstOrDefault(x => x.Id == id);
            RoleUpdateViewModel model = new RoleUpdateViewModel
            {
                Id = values.Id,
                Name = values.Name
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateViewModel model)
        {
            var role = _manager.Roles.FirstOrDefault(i => i.Id == model.Id);
            role.Name = model.Name;
            var result = await _manager.UpdateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

            }
            return View(model);
        }
        public async Task<IActionResult> DeleteRole(int Id)
        {
            var values = _manager.Roles.FirstOrDefault(i => i.Id == Id);
            var result = await _manager.DeleteAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }

        public IActionResult UserList()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole(int Id)
        {
            var user = _userManager.Users.FirstOrDefault(i => i.Id == Id);
            var roles = _manager.Roles.ToList();
            TempData["UserId"] = user.Id;
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> model = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel m = new RoleAssignViewModel();
                m.RoleId = item.Id;
                m.Name = item.Name;
                m.Exists = userRoles.Contains(item.Name);
                model.Add(m);
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userId = (int)TempData["UserId"];
            var user = _userManager.Users.FirstOrDefault(i => i.Id == userId);
            foreach (var item in model)
            {
                if (item.Exists)
                {
                    await _userManager.AddToRoleAsync(user, item.Name);

                }
                await _userManager.RemoveFromRoleAsync(user, item.Name);
            }

            return RedirectToAction("UserList");
        }
    }
}
