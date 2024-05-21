using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public SocialMediasController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia()
        {
            var values = _serviceManager.SocialMediaService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetSocialMediaById/{id}")]
        public IActionResult GetSocialMediaById(int id)
        {
            var values = _serviceManager.SocialMediaService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            _serviceManager.SocialMediaService.TInsert(socialMedia);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateSocialMedia")]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            _serviceManager.SocialMediaService.TUpdate(socialMedia);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteSocialMedia/{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            _serviceManager.SocialMediaService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
