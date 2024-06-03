using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Areas.Admin.Controllers;
using MilkyProject.WebUI.Models;
using NToastNotify;

namespace MilkyProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class NewsletterController : Controller
    {
        private readonly DynamicConsume<Newsletter> _dynamicConsumeNewsletter;
        private readonly IToastNotification _toastNotification;

        public NewsletterController(DynamicConsume<Newsletter> dynamicConsumeNewsletter, IToastNotification toastNotification)
        {
            _dynamicConsumeNewsletter = dynamicConsumeNewsletter;
            _toastNotification = toastNotification;
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewsletter(Newsletter newsletter)
        {
            var result = await _dynamicConsumeNewsletter.PostAsync("Newsletters/CreateNewsletter", newsletter);
            if(result>0)
            {
                //_toastNotification.AddAlertToastMessage("Mesaj", new ToastrOptions { Title = "Deneme" });
                _toastNotification.AddSuccessToastMessage("Mail Bültenine Kaydınız Tamamlandı.", new ToastrOptions { Title = "Başarılı !" });
                return RedirectToAction("Index","Default");
            }
            return RedirectToAction("Index", "Default");
        }
    }
}
