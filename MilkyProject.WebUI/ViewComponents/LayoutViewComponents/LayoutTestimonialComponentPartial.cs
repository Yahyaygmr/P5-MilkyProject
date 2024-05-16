using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutTestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
