using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurServicesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public OurServicesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetOurService")]
        public IActionResult GetOurService()
        {
            var values = _serviceManager.OurServiceService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetOurServiceById/{id}")]
        public IActionResult GetOurServiceById(int id)
        {
            var values = _serviceManager.OurServiceService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateOurService(OurService ourService)
        {
            _serviceManager.OurServiceService.TInsert(ourService);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateOurService")]
        public IActionResult UpdateOurService(OurService ourService)
        {
            _serviceManager.OurServiceService.TUpdate(ourService);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteOurService/{id}")]
        public IActionResult DeleteOurService(int id)
        {
            _serviceManager.OurServiceService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
