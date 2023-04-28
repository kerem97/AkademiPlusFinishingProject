using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusFinishingProject.ViewComponents.Default
{
    public class _Policy : ViewComponent
    {
        private readonly IPolicyService _policyService;

        public _Policy(IPolicyService policyService)
        {
            _policyService = policyService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _policyService.TGetListAll();
            return View(values);
        }
    }
}
