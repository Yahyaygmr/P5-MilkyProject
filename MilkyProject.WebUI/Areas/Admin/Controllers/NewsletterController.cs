using Microsoft.AspNetCore.Mvc;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class NewsletterController : Controller
    {
        private readonly DynamicConsume<Newsletter> _dynamicConsumeNewsletter;

        public NewsletterController(DynamicConsume<Newsletter> dynamicConsumeNewsletter)
        {
            _dynamicConsumeNewsletter = dynamicConsumeNewsletter;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _dynamicConsumeNewsletter.GetListAsync("Newsletters/NewsletterList");

            return View(values);
        }
    }
}
