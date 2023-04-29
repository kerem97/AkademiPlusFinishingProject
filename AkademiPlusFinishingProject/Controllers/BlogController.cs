using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;

        public BlogController(IBlogService blogService, ICommentService commentService)
        {
            _blogService = blogService;
            _commentService = commentService;
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
