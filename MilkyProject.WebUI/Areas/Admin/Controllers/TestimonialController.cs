using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.TestimonialDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class TestimonialController : Controller
    {
        private readonly DynamicConsume<ResultTestimonialDto> _resultTestimonial;
        private readonly DynamicConsume<UpdateTestimonialDto> _updateTestimonial;
        private readonly DynamicConsume<CreateTestimonialDto> _createTestimonial;
        private readonly DynamicConsume<object> _objectTestimonial;

        public TestimonialController(DynamicConsume<ResultTestimonialDto> resultTestimonial, DynamicConsume<UpdateTestimonialDto> updateTestimonial, DynamicConsume<CreateTestimonialDto> createTestimonial, DynamicConsume<object> objectTestimonial)
        {
            _resultTestimonial = resultTestimonial;
            _updateTestimonial = updateTestimonial;
            _createTestimonial = createTestimonial;
            _objectTestimonial = objectTestimonial;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultTestimonial.GetListAsync("Testimonials/GetTestimonial");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto dto)
        {
            var result = await _createTestimonial.PostAsync("Testimonials", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var values = await _updateTestimonial.GetByIdAsync("Testimonials/GetTestimonialById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto dto)
        {
            var result = await _updateTestimonial.PutAsync("Testimonials/UpdateTestimonial", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var result = await _objectTestimonial.DeleteAsync("Testimonials/DeleteTestimonial", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
