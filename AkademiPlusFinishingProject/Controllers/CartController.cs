using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Controllers
{
    [AllowAnonymous]
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
