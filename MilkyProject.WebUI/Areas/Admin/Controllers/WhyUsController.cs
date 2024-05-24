using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.WhyUsDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class WhyUsController : Controller
    {
        private readonly DynamicConsume<ResultWhyUsDto> _resultWhyUs;
        private readonly DynamicConsume<UpdateWhyUsDto> _updateWhyUs;
        private readonly DynamicConsume<CreateWhyUsDto> _createWhyUs;
        private readonly DynamicConsume<object> _objectWhyUs;

        public WhyUsController(DynamicConsume<ResultWhyUsDto> resultWhyUs, DynamicConsume<UpdateWhyUsDto> updateWhyUs, DynamicConsume<CreateWhyUsDto> createWhyUs, DynamicConsume<object> objectWhyUs)
        {
            _resultWhyUs = resultWhyUs;
            _updateWhyUs = updateWhyUs;
            _createWhyUs = createWhyUs;
            _objectWhyUs = objectWhyUs;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultWhyUs.GetListAsync("WhyUss/GetWhyUs");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateWhyUs()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhyUs(CreateWhyUsDto dto)
        {
            var result = await _createWhyUs.PostAsync("WhyUss", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateWhyUs(int id)
        {
            var values = await _updateWhyUs.GetByIdAsync("WhyUss/GetWhyUsById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateWhyUs(UpdateWhyUsDto dto)
        {
            var result = await _updateWhyUs.PutAsync("WhyUss/UpdateWhyUs", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteWhyUs(int id)
        {
            var result = await _objectWhyUs.DeleteAsync("WhyUss/DeleteWhyUs", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
