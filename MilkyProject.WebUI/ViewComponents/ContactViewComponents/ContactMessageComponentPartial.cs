using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents.ContactViewComponents
{
    public class ContactMessageComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
