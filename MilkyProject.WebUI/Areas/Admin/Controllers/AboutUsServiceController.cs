using DynamicConsume;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.AboutUsServiceDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class AboutUsServiceController : Controller
    {
        private readonly Consume<ResultAboutUsServiceDto> _resultAboutUsService;
        private readonly Consume<UpdateAboutUsServiceDto> _updateAboutUsService;
        private readonly Consume<CreateAboutUsServiceDto> _createAboutUsService;
        private readonly Consume<object> _objectAboutUsService;

        public AboutUsServiceController(Consume<ResultAboutUsServiceDto> resultAboutUsService, Consume<UpdateAboutUsServiceDto> updateAboutUsService, Consume<CreateAboutUsServiceDto> createAboutUsService, Consume<object> objectAboutUsService)
        {
            _resultAboutUsService = resultAboutUsService;
            _updateAboutUsService = updateAboutUsService;
            _createAboutUsService = createAboutUsService;
            _objectAboutUsService = objectAboutUsService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultAboutUsService.GetListAsync("AboutUsServices/GetAboutUsService");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateAboutUsService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAboutUsService(CreateAboutUsServiceDto dto)
        {
            var result = await _createAboutUsService.PostAsync("AboutUsServices", dto);
            if(result>0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAboutUsService(int id)
        {
            var values = await _updateAboutUsService.GetByIdAsync("AboutUsServices/GetAboutUsServiceById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAboutUsService(UpdateAboutUsServiceDto dto)
        {
            var result = await _updateAboutUsService.PutAsync("AboutUsServices/UpdateAboutUsService", dto);
            if (result>0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteAboutUsService(int id)
        {
            var result = await _objectAboutUsService.DeleteAsync("AboutUsServices/DeleteAboutUsService", id);
            if (result>0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
