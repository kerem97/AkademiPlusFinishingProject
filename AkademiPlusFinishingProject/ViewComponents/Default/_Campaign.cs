using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Default
{
    public class _Campaign : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
