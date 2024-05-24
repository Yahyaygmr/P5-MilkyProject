using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.SliderDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class SliderController : Controller
    {
        private readonly DynamicConsume<ResultSliderDto> _resultSlider;
        private readonly DynamicConsume<UpdateSliderDto> _updateSlider;
        private readonly DynamicConsume<CreateSliderDto> _createSlider;
        private readonly DynamicConsume<object> _objectSlider;

        public SliderController(DynamicConsume<ResultSliderDto> resultSlider, DynamicConsume<UpdateSliderDto> updateSlider, DynamicConsume<CreateSliderDto> createSlider, DynamicConsume<object> objectSlider)
        {
            _resultSlider = resultSlider;
            _updateSlider = updateSlider;
            _createSlider = createSlider;
            _objectSlider = objectSlider;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultSlider.GetListAsync("Sliders/GetSlider");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto dto)
        {
            var result = await _createSlider.PostAsync("Sliders", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateSlider(int id)
        {
            var values = await _updateSlider.GetByIdAsync("Sliders/GetSliderById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto dto)
        {
            var result = await _updateSlider.PutAsync("Sliders/UpdateSlider", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteSlider(int id)
        {
            var result = await _objectSlider.DeleteAsync("Sliders/DeleteSlider", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
