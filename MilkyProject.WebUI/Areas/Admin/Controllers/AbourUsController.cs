using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.AboutUsDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class AbourUsController : Controller
    {
        private readonly DynamicConsume<UpdateAboutUsDto> _dynamicConsumeUpdateAbout;

        public AbourUsController(DynamicConsume<UpdateAboutUsDto> dynamicConsumeUpdateAbout)
        {
            _dynamicConsumeUpdateAbout = dynamicConsumeUpdateAbout;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id=1)
        {
            var value =await _dynamicConsumeUpdateAbout.GetByIdAsync("AboutUses/GetAboutUsById", id);
            if(value != null)
            {
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UpdateAboutUsDto dto)
        {
            int result = await _dynamicConsumeUpdateAbout.PutAsync("AboutUses/UpdateAboutUs", dto);
            if(result>0)
            {
                return View("Index");
            }
            return View();
        }
    }
}
