using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class NewArrivalController : Controller
    {
        private readonly INewArrivalService _newArrivalService;

        public NewArrivalController(INewArrivalService newArrivalService)
        {
            _newArrivalService = newArrivalService;
        }

        public IActionResult Index()
        {
            var values = _newArrivalService.TGetList();
            return View(values);
        }
        public IActionResult DeleteNewArrival(int id)
        {
            var values = _newArrivalService.TGetByID(id);
            _newArrivalService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateNewArrival(int id)
        {
            var values = _newArrivalService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateNewArrival(NewArrival newArrival)
        {
            
            _newArrivalService.TUpdate(newArrival);
            return RedirectToAction("Index");
        }

    }
}
