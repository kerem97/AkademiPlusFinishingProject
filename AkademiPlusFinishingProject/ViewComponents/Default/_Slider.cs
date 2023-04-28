using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Default
{
    public class _Slider : ViewComponent
    {
        private readonly ISliderPhotoService _sliderPhotoService;

        public _Slider(ISliderPhotoService sliderPhotoService)
        {
            _sliderPhotoService = sliderPhotoService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _sliderPhotoService.TGetListAll();
            return View(values);
        }
    }
}
