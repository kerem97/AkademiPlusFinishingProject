using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly INewArrivalService _newArrivalService;
        private readonly ICategoryService _categoryService;

      
        public IActionResult Index()
        {
            return View();
        }
    }
}
