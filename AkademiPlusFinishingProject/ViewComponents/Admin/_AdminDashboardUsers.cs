using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Admin
{
    public class _AdminDashboardUsers : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var values = c.Users.ToList();
            return View(values);
        }
    }
}
