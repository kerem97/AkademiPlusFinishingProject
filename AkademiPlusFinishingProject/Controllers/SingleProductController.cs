using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Controllers
{
    [AllowAnonymous]
    public class SingleProductController : Controller
    {
        private readonly INewArrivalService _newArrivalService;

        public SingleProductController(INewArrivalService newArrivalService)
        {
            _newArrivalService = newArrivalService;
        }

        public IActionResult Index(int id)
        {
            var values=_newArrivalService.TGetByID(id);
            return View(values);
        }
    }
}
