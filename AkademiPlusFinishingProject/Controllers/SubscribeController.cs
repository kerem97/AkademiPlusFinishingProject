using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeMail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubscribeMail(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return RedirectToAction("Index", "Default");
        }
    }
}
