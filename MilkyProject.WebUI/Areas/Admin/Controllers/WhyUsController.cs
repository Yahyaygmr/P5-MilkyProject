using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.WhyUsDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class WhyUsController : Controller
    {
        private readonly DynamicConsume<UpdateWhyUsDto> _dynamicConsumeUpdateAbout;

        public WhyUsController(DynamicConsume<UpdateWhyUsDto> dynamicConsumeUpdateAbout)
        {
            _dynamicConsumeUpdateAbout = dynamicConsumeUpdateAbout;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id = 1)
        {
            var value = await _dynamicConsumeUpdateAbout.GetByIdAsync("WhyUses/GetWhyUsById", id);
            if (value != null)
            {
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UpdateWhyUsDto dto)
        {
            int result = await _dynamicConsumeUpdateAbout.PutAsync("WhyUses/UpdateWhyUs", dto);
            if (result > 0)
            {
                return View("Index");
            }
            return View();
        }
    }
}
