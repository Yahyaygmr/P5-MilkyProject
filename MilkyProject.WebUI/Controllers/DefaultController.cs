using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
