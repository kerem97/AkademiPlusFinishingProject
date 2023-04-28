using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Comment
{
    public class _CommentListByBlog : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentListByBlog(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetByID(id);
            return View(values);
        }
    }
}
