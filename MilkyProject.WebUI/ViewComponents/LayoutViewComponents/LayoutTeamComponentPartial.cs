using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutTeamComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
