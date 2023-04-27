using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Default
{
    public class _Blog : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
