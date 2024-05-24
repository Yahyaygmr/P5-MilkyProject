using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.BusinessHourDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class BusinessHourController : Controller
    {
        private readonly DynamicConsume<ResultBusinessHourDto> _resultBusinessHour;
        private readonly DynamicConsume<UpdateBusinessHourDto> _updateBusinessHour;
        private readonly DynamicConsume<CreateBusinessHourDto> _createBusinessHour;
        private readonly DynamicConsume<object> _objectBusinessHour;

        public BusinessHourController(DynamicConsume<ResultBusinessHourDto> resultBusinessHour, DynamicConsume<UpdateBusinessHourDto> updateBusinessHour, DynamicConsume<CreateBusinessHourDto> createBusinessHour, DynamicConsume<object> objectBusinessHour)
        {
            _resultBusinessHour = resultBusinessHour;
            _updateBusinessHour = updateBusinessHour;
            _createBusinessHour = createBusinessHour;
            _objectBusinessHour = objectBusinessHour;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultBusinessHour.GetListAsync("BusinessHours/GetBusinessHour");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateBusinessHour()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBusinessHour(CreateBusinessHourDto dto)
        {
            var result = await _createBusinessHour.PostAsync("BusinessHours", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBusinessHour(int id)
        {
            var values = await _updateBusinessHour.GetByIdAsync("BusinessHours/GetBusinessHourById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBusinessHour(UpdateBusinessHourDto dto)
        {
            var result = await _updateBusinessHour.PutAsync("BusinessHours/UpdateBusinessHour", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteBusinessHour(int id)
        {
            var result = await _objectBusinessHour.DeleteAsync("BusinessHours/DeleteBusinessHour", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
