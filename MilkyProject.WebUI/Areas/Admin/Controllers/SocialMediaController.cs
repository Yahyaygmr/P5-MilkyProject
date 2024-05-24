using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.SocialMediaDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class SocialMediaController : Controller
    {
        private readonly DynamicConsume<ResultSocialMediaDto> _resultSocialMedia;
        private readonly DynamicConsume<UpdateSocialMediaDto> _updateSocialMedia;
        private readonly DynamicConsume<CreateSocialMediaDto> _createSocialMedia;
        private readonly DynamicConsume<object> _objectSocialMedia;

        public SocialMediaController(DynamicConsume<ResultSocialMediaDto> resultSocialMedia, DynamicConsume<UpdateSocialMediaDto> updateSocialMedia, DynamicConsume<CreateSocialMediaDto> createSocialMedia, DynamicConsume<object> objectSocialMedia)
        {
            _resultSocialMedia = resultSocialMedia;
            _updateSocialMedia = updateSocialMedia;
            _createSocialMedia = createSocialMedia;
            _objectSocialMedia = objectSocialMedia;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultSocialMedia.GetListAsync("SocialMedias/GetSocialMedia");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaDto dto)
        {
            var result = await _createSocialMedia.PostAsync("SocialMedias", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateSocialMedia(int id)
        {
            var values = await _updateSocialMedia.GetByIdAsync("SocialMedias/GetSocialMediaById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaDto dto)
        {
            var result = await _updateSocialMedia.PutAsync("SocialMedias/UpdateSocialMedia", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            var result = await _objectSocialMedia.DeleteAsync("SocialMedias/DeleteSocialMedia", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
