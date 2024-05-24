using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.GalleryDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class GalleryController : Controller
    {
        private readonly DynamicConsume<ResultGalleryDto> _resultGallery;
        private readonly DynamicConsume<UpdateGalleryDto> _updateGallery;
        private readonly DynamicConsume<CreateGalleryDto> _createGallery;
        private readonly DynamicConsume<object> _objectGallery;

        public GalleryController(DynamicConsume<ResultGalleryDto> resultGallery, DynamicConsume<UpdateGalleryDto> updateGallery, DynamicConsume<CreateGalleryDto> createGallery, DynamicConsume<object> objectGallery)
        {
            _resultGallery = resultGallery;
            _updateGallery = updateGallery;
            _createGallery = createGallery;
            _objectGallery = objectGallery;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultGallery.GetListAsync("Gallerys/GetGallery");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateGallery()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateGallery(CreateGalleryDto dto)
        {
            var result = await _createGallery.PostAsync("Gallerys", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateGallery(int id)
        {
            var values = await _updateGallery.GetByIdAsync("Gallerys/GetGalleryById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateGallery(UpdateGalleryDto dto)
        {
            var result = await _updateGallery.PutAsync("Gallerys/UpdateGallery", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteGallery(int id)
        {
            var result = await _objectGallery.DeleteAsync("Gallerys/DeleteGallery", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
