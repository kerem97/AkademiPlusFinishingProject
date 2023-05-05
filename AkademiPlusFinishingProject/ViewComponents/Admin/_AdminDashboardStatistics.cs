using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Admin
{
    public class _AdminDashboardStatistics : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.category = c.Categories.Count();
            ViewBag.fProduct = c.NewArrivals.Count();
            ViewBag.users = c.Users.Count();
            ViewBag.blogs = c.Blogs.Count();
            return View();
        }
    }
}
