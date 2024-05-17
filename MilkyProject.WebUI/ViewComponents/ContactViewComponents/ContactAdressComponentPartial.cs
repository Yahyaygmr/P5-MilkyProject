using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents.ContactViewComponents
{
    public class ContactAdressComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
