using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutGalleryComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
