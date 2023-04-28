using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var values = _blogService.TGetList();
            return View(values);
        }
        public ActionResult BlogDetails(int id)
        {
            ViewBag.i = id;
            var values = _blogService.TGetBlogByID(id);
            return View(values);
        }
    }
}
