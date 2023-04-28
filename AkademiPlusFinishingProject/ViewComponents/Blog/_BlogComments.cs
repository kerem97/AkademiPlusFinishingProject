using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Blog
{
    public class _BlogComments : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
