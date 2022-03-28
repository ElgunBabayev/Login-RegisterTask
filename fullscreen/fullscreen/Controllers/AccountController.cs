using fullscreen.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fullscreen.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        public AccountController(UserManager<AppUser> _userManager)
        {
            userManager = _userManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (!ModelState.IsValid) return View();

            AppUser newUser = new AppUser
            {
                FullName = rvm.FirstName + " " + rvm.LastName,
                Email = rvm.Email,


            };

            IdentityResult identityResult = await userManager.CreateAsync(newUser, rvm.Password);

            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return Json(rvm);

        }
    }
}
