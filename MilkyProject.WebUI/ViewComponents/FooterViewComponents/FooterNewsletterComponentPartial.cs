using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents.FooterViewComponents
{
    public class FooterNewsletterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
