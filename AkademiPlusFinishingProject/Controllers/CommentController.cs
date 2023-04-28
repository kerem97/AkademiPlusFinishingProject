using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Controllers
{
    public class CommentController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialCommentListByBlog(int id)
        {
            //var values = cm.TGetList(id);
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult PartialAddcomment()
        {

            return PartialView();
        }
        [HttpGet]
        public PartialViewResult PartialAddcomment(Comment c)
        {

            return PartialView();
        }

    }
}
