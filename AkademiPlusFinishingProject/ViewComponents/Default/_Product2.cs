using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Default
{
    public class _Product2 : ViewComponent
    {
        private readonly INewArrivalService _arrivalService;

        public _Product2(INewArrivalService arrivalService)
        {
            _arrivalService = arrivalService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _arrivalService.TGetListAll();
            return View(values);
        }
    }
}
