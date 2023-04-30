using AkademiPlusFinishingProject.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            AppUser appUser = new AppUser()
            {
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,
                Email = registerViewModel.Email,
                UserName = registerViewModel.Username,
                City = registerViewModel.City,
                ImageUrl = "test"


            };


            var result = await _userManager.CreateAsync(appUser, registerViewModel.Password);
            if (result.Succeeded)
            {
                //string cftoken = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);

                //string link = Url.Action("ConfirmEmail", "Register", new

                //{
                //    userId = appUser.Id,
                //    token = cftoken
                //}, protocol: HttpContext.Request.Scheme

                //    );

                //EmailConfirmation.SendEmail(link, appUser.Email);

                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError("", x.Description);
                }
            }
            return View();
        }


        //public async Task<IActionResult> ConfirmEmail(string userId, string token)
        //{

        //    var user = await _userManager.FindByIdAsync(userId);


        //    IdentityResult result = await _userManager.ConfirmEmailAsync(user, token);
        //    if (result.Succeeded)
        //    {
        //        ViewBag.status = "Tebrikler artık giriş yapabilirsiniz";
        //    }
        //    else
        //    {
        //        ViewBag.status = "Bir hata meydana geldi";
        //    }

        //    return View();


        //}





    }
}