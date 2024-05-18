using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsServicesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public AboutUsServicesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetAboutUsService")]
        public IActionResult GetAboutUsService()
        {
            var values = _serviceManager.AboutUsServiceService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetAboutUsServiceById/{id}")]
        public IActionResult GetAboutUsServiceById(int id)
        {
            var values = _serviceManager.AboutUsServiceService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAboutUsService(AboutUsService aboutUsService)
        {
            _serviceManager.AboutUsServiceService.TInsert(aboutUsService);
            return Ok("Hakımızda Hizmet Alanı Eklendi");
        }
        [HttpPut("UpdateAboutUsService")]
        public IActionResult UpdateAboutUsService(AboutUsService aboutUsService)
        {
            _serviceManager.AboutUsServiceService.TUpdate(aboutUsService);
            return Ok("Hakımızda Hizmet Alanı Güncellendi");
        }
        [HttpDelete("DeleteAboutUsService/{id}")]
        public IActionResult DeleteAboutUsService(int id)
        {
            _serviceManager.AboutUsServiceService.TDelete(id);
            return Ok("Hakımızda Hizmet Alanı Silindi");
        }
    }
}
