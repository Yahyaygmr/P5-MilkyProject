using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessHoursController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public BusinessHoursController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetBusinessHour")]
        public IActionResult GetBusinessHour()
        {
            var values = _serviceManager.BusinessHourService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetBusinessHourById/{id}")]
        public IActionResult GetBusinessHourById(int id)
        {
            var values = _serviceManager.BusinessHourService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBusinessHour(BusinessHour BusinessHour)
        {
            _serviceManager.BusinessHourService.TInsert(BusinessHour);
            return Ok("Çalışma Saatleri Alanı Eklendi");
        }
        [HttpPut("UpdateBusinessHour")]
        public IActionResult UpdateBusinessHour(BusinessHour BusinessHour)
        {
            _serviceManager.BusinessHourService.TUpdate(BusinessHour);
            return Ok("Çalışma Saatleri Alanı Güncellendi");
        }
        [HttpDelete("DeleteBusinessHour/{id}")]
        public IActionResult DeleteBusinessHour(int id)
        {
            _serviceManager.BusinessHourService.TDelete(id);
            return Ok("Çalışma Saatleri Alanı Silindi");
        }
    }
}
