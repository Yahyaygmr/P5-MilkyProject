using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhyUsesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public WhyUsesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetWhyUs")]
        public IActionResult GetWhyUs()
        {
            var values = _serviceManager.WhyUsService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetWhyUsById/{id}")]
        public IActionResult GetWhyUsById(int id)
        {
            var values = _serviceManager.WhyUsService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateWhyUs(WhyUs WhyUs)
        {
            _serviceManager.WhyUsService.TInsert(WhyUs);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateWhyUs")]
        public IActionResult UpdateWhyUs(WhyUs WhyUs)
        {
            _serviceManager.WhyUsService.TUpdate(WhyUs);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteWhyUs/{id}")]
        public IActionResult DeleteWhyUs(int id)
        {
            _serviceManager.WhyUsService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
