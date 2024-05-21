using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public SlidersController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetSlider")]
        public IActionResult GetSlider()
        {
            var values = _serviceManager.SliderService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetSliderById/{id}")]
        public IActionResult GetSliderById(int id)
        {
            var values = _serviceManager.SliderService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateSlider(Slider Slider)
        {
            _serviceManager.SliderService.TInsert(Slider);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateSlider")]
        public IActionResult UpdateSlider(Slider Slider)
        {
            _serviceManager.SliderService.TUpdate(Slider);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteSlider/{id}")]
        public IActionResult DeleteSlider(int id)
        {
            _serviceManager.SliderService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
