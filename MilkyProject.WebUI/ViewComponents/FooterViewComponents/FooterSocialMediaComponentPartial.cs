using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents.FooterViewComponents
{
    public class FooterSocialMediaComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
