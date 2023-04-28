using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Default
{
    public class _Brand : ViewComponent
    {
        private readonly IBrandService _brandService;

        public _Brand(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _brandService.TGetList();
            return View(values);
        }
    }
}
