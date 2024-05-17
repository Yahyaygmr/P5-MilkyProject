using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
