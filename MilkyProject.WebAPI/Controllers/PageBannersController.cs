using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageBannersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public PageBannersController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetPageBanner")]
        public IActionResult GetPageBanner()
        {
            var values = _serviceManager.PageBannerService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetPageBannerById/{id}")]
        public IActionResult GetPageBannerById(int id)
        {
            var values = _serviceManager.PageBannerService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreatePageBanner(PageBanner pageBanner)
        {
            _serviceManager.PageBannerService.TInsert(pageBanner);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdatePageBanner")]
        public IActionResult UpdatePageBanner(PageBanner pageBanner)
        {
            _serviceManager.PageBannerService.TUpdate(pageBanner);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeletePageBanner/{id}")]
        public IActionResult DeletePageBanner(int id)
        {
            _serviceManager.PageBannerService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
