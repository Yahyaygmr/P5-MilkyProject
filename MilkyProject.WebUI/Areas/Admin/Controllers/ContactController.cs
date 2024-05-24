using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.ContactDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class ContactController : Controller
    {
        private readonly DynamicConsume<UpdateContactDto> _dynamicConsumeUpdateAbout;

        public ContactController(DynamicConsume<UpdateContactDto> dynamicConsumeUpdateAbout)
        {
            _dynamicConsumeUpdateAbout = dynamicConsumeUpdateAbout;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id = 1)
        {
            var value = await _dynamicConsumeUpdateAbout.GetByIdAsync("Contacts/GetContactById", id);
            if (value != null)
            {
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UpdateContactDto dto)
        {
            int result = await _dynamicConsumeUpdateAbout.PutAsync("Contacts/UpdateContact", dto);
            if (result > 0)
            {
                return View("Index");
            }
            return View();
        }
    }
}
