using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutPageBannerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
