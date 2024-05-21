using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhyUsDetailsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public WhyUsDetailsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetWhyUsDetail")]
        public IActionResult GetWhyUsDetail()
        {
            var values = _serviceManager.WhyUsDetailService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetWhyUsDetailById/{id}")]
        public IActionResult GetWhyUsDetailById(int id)
        {
            var values = _serviceManager.WhyUsDetailService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateWhyUsDetail(WhyUsDetail WhyUsDetail)
        {
            _serviceManager.WhyUsDetailService.TInsert(WhyUsDetail);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateWhyUsDetail")]
        public IActionResult UpdateWhyUsDetail(WhyUsDetail WhyUsDetail)
        {
            _serviceManager.WhyUsDetailService.TUpdate(WhyUsDetail);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteWhyUsDetail/{id}")]
        public IActionResult DeleteWhyUsDetail(int id)
        {
            _serviceManager.WhyUsDetailService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
