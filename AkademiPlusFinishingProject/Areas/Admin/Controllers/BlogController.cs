using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AkademiPlusFinishingProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            Context c = new Context();
            var values = _blogService.TGetBlogByCategory();
            return View(values);
        }

        public IActionResult DeleteBlog(int id)
        {
            var values = _blogService.TGetByID(id);
            _blogService.TDelete(values);
            return RedirectToAction("Index");
        }


    }
}
