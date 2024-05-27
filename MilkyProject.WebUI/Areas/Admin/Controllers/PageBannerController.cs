using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.PageBannerDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class PageBannerController : Controller
    {
        private readonly DynamicConsume<UpdatePageBannerDto> _dynamicConsumeUpdateAbout;

        public PageBannerController(DynamicConsume<UpdatePageBannerDto> dynamicConsumeUpdateAbout)
        {
            _dynamicConsumeUpdateAbout = dynamicConsumeUpdateAbout;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id = 1)
        {
            var value = await _dynamicConsumeUpdateAbout.GetByIdAsync("PageBanners/GetPageBannerById", id);
            if (value != null)
            {
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UpdatePageBannerDto dto)
        {
            int result = await _dynamicConsumeUpdateAbout.PutAsync("PageBanners/UpdatePageBanner", dto);
            if (result > 0)
            {
                return View("Index");
            }
            return View();
        }
    }
}
