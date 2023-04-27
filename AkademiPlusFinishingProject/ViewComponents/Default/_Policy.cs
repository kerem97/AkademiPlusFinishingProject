using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Default
{
    public class _Policy : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
