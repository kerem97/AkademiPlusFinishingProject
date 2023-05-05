using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace AkademiPlusFinishingProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IBlogService _blogService;

        public BlogController(UserManager<AppUser> userManager, IBlogService blogService)
        {
            _userManager = userManager;
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<IActionResult> AddBlog(int id)
        {

            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> categoryvalues = (from x in cm.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()

                                                   }).ToList();

            ViewBag.cv = categoryvalues;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBlog(Blog blog)
        {

            var userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(blog);
            if (results.IsValid)
            {
                //var resource = Directory.GetCurrentDirectory();
                //var extension = Path.GetExtension(blog.BlogImage.FileName.ToString());
                //var imagename = Guid.NewGuid() + extension;
                //var savelocation = resource + "/wwwroot/UserImages/" + imagename;
                //var stream = new FileStream(savelocation, FileMode.Create);
                //await blog.BlogImage.CopyToAsync(stream);
                //user.ImageUrl = imagename;

                blog.AddDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.AppUserID = user.Id;
                blog.BlogImage = "deneme";
                _blogService.TInsert(blog);
                return RedirectToAction("Index", "Dashboard", new { area = "Member" });
            }

            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
        }
    }

}
