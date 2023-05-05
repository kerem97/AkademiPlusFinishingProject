using AkademiPlusFinishingProject.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
        public async Task<IActionResult> Index(LoginViewModel lgn)
        {
            AppUser appUser = await _userManager.FindByNameAsync(lgn.Username);

            var result = await _signInManager.PasswordSignInAsync(lgn.Username, lgn.Password, false, false);

            if (result.Succeeded )
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Member" });
            }

            //else
            //{
            //    ModelState.AddModelError(" ", "Lütfen mail adresinizi onaylayınız");
            //    return View();
            //}

            if (_userManager.IsEmailConfirmedAsync(appUser).Result == false)
            {
                ModelState.AddModelError("", "Email adresiniz doğrulanmamıştır lütfen mail adresinizi onaylayıp tekrar deneyiniz");
                return View(lgn);
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {

            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> AdminLogin(LoginViewModel lgn)
        {
            AppUser appUser = await _userManager.FindByNameAsync(lgn.Username);

            var result = await _signInManager.PasswordSignInAsync(lgn.Username, lgn.Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }

            //else
            //{
            //    ModelState.AddModelError(" ", "Lütfen mail adresinizi onaylayınız");
            //    return View();
            //}

            if (_userManager.IsEmailConfirmedAsync(appUser).Result == false)
            {
                ModelState.AddModelError("", "Buradan sadece admin olarak giriş yapabilmek mümkündür.");
                return View(lgn);
            }
            return View();
        }

    }
}