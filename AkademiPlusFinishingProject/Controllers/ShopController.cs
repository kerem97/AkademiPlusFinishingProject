using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Controllers
{
    [AllowAnonymous]
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
