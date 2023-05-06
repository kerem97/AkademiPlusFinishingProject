using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.SingleProduct
{
    public class _SingleProductGallery : ViewComponent
    {
        private readonly INewArrivalService _newArrivalService;

        public _SingleProductGallery(INewArrivalService newArrivalService)
        {
            _newArrivalService = newArrivalService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _newArrivalService.TGetList();
            return View(values);
        }
    }
}
