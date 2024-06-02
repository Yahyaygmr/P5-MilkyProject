using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Areas.Admin.Controllers;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class NewsletterController : Controller
    {
        private readonly DynamicConsume<Newsletter> _dynamicConsumeNewsletter;

        public NewsletterController(DynamicConsume<Newsletter> dynamicConsumeNewsletter)
        {
            _dynamicConsumeNewsletter = dynamicConsumeNewsletter;
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewsletter(Newsletter newsletter)
        {
            var result = await _dynamicConsumeNewsletter.PostAsync("Newsletters/CreateNewsletter", newsletter);
            if(result>0)
            {
                return RedirectToAction("Index","Default");
            }
            return RedirectToAction("Index", "Default");
        }
    }
}
