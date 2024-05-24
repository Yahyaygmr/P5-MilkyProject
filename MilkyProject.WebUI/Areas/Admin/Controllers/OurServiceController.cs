using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.OurServiceDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class OurServiceController : Controller
    {
        private readonly DynamicConsume<ResultOurServiceDto> _resultOurService;
        private readonly DynamicConsume<UpdateOurServiceDto> _updateOurService;
        private readonly DynamicConsume<CreateOurServiceDto> _createOurService;
        private readonly DynamicConsume<object> _objectOurService;

        public OurServiceController(DynamicConsume<ResultOurServiceDto> resultOurService, DynamicConsume<UpdateOurServiceDto> updateOurService, DynamicConsume<CreateOurServiceDto> createOurService, DynamicConsume<object> objectOurService)
        {
            _resultOurService = resultOurService;
            _updateOurService = updateOurService;
            _createOurService = createOurService;
            _objectOurService = objectOurService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultOurService.GetListAsync("OurServices/GetOurService");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateOurService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateOurService(CreateOurServiceDto dto)
        {
            var result = await _createOurService.PostAsync("OurServices", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateOurService(int id)
        {
            var values = await _updateOurService.GetByIdAsync("OurServices/GetOurServiceById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateOurService(UpdateOurServiceDto dto)
        {
            var result = await _updateOurService.PutAsync("OurServices/UpdateOurService", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteOurService(int id)
        {
            var result = await _objectOurService.DeleteAsync("OurServices/DeleteOurService", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
