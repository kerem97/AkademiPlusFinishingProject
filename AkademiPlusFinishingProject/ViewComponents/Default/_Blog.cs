using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Default
{
    public class _Blog : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _Blog(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _blogService.TGetBlogByCategory();
            return View(values);
        }
    }
}
