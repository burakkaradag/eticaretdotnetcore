using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Areas.Admin.Model;
using ETicaret.DAL;
using ETicaret.REP;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ETicaretContext _db;
        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ETicaretContext db)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _db = db;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel lm)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(lm.UserName);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, lm.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Gallery");
                    }
                    else
                    {
                        ViewData["Error"] = "Kullanıcı Bulunamadı";
                    }
                }
                return View(lm);
            }
            return View(lm);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser();
                user.UserName = model.UserName;
                user.Email = model.Email;
               

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //_userManager.AddToRoleAsync(user.Id, "Admin");
                    await _db.SaveChangesAsync();
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUser", "Kullanıcı Ekleme İşleminde Hata");
                }
                //return View(model);
            }
            return View(model);
        }
        public async Task<IActionResult> LogOut()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}