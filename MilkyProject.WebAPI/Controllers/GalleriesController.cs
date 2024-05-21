using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleriesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public GalleriesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetGallery")]
        public IActionResult GetGallery()
        {
            var values = _serviceManager.GalleryService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetGalleryById/{id}")]
        public IActionResult GetGalleryById(int id)
        {
            var values = _serviceManager.GalleryService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateGallery(Gallery gallery)
        {
            _serviceManager.GalleryService.TInsert(gallery);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateGallery")]
        public IActionResult UpdateGallery(Gallery gallery)
        {
            _serviceManager.GalleryService.TUpdate(gallery);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteGallery/{id}")]
        public IActionResult DeleteGallery(int id)
        {
            _serviceManager.GalleryService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
