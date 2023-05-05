using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Areas.Member.Controllers
{

    [Area("Member")]


    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IBlogService _blogService;

        public DashboardController(UserManager<AppUser> userManager, IBlogService blogService)
        {
            _userManager = userManager;
            _blogService = blogService;
        }

        //[Authorize(Roles = "Member")]
        public async Task<IActionResult> Index()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Name + " " + values.Surname;
            var getlastblogs = _blogService.TGetLast3Blog();
            return View(getlastblogs);
        }
    }
}