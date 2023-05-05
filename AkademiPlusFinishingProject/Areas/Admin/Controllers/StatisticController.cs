using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.categoryCount = c.Categories.Count();
            ViewBag.newArrivalsCount = c.NewArrivals.Count();
            ViewBag.blogCount = c.Blogs.Count();
            ViewBag.discount = c.NewArrivals.Where(x => x.Discount <= 50).Count();
            ViewBag.priceUnder100 = c.NewArrivals.Where(x => x.NewPrice <= 100).Count();
            ViewBag.avgPrice = c.NewArrivals.Average(x => x.NewPrice);
            ViewBag.brandsCount = c.Brands.Count();
            ViewBag.userCount = c.Users.Count();
            ViewBag.contactCount = c.Contacts.Count();
            ViewBag.commentCount = c.Comments.Count();

            ViewBag.subscribeCount = c.Subscribes.Count();
            return View();
        }
    }
}
