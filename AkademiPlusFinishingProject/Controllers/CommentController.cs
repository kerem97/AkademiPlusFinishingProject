using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpPost]
        public IActionResult Addcomment(Comment c)
        {

            _commentService.TInsert(c);

            return RedirectToAction("BlogDetails", "Blog", new { id = c.BlogID });
        }
        public IActionResult Index()
        {
            return View();
        }

        //public PartialViewResult PartialCommentListByBlog(int id)
        //{
        //    //var values = cm.TGetList(id);
        //    return PartialView();
        //}



    }
}
