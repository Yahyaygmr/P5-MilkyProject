using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public TestimonialsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial()
        {
            var values = _serviceManager.TestimonialService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetTestimonialById/{id}")]
        public IActionResult GetTestimonialById(int id)
        {
            var values = _serviceManager.TestimonialService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial Testimonial)
        {
            _serviceManager.TestimonialService.TInsert(Testimonial);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateTestimonial")]
        public IActionResult UpdateTestimonial(Testimonial Testimonial)
        {
            _serviceManager.TestimonialService.TUpdate(Testimonial);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteTestimonial/{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            _serviceManager.TestimonialService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
