using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public AboutUsesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetAboutUs")]
        public IActionResult GetAboutUs()
        {
            var values = _serviceManager.AboutUsService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetAboutUsById/{id}")]
        public IActionResult GetAboutUsById(int id)
        {
            var values = _serviceManager.AboutUsService.TGetById(id);
            return Ok(values);
        }
        [HttpPut("UpdateAboutUs")]
        public IActionResult UpdateAboutUs(AboutUs aboutUs)
        {
            _serviceManager.AboutUsService.TUpdate(aboutUs);
            return Ok("Hakımızda Alanı Güncellendi");
        }
    }
}
