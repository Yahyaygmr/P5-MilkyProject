using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.TeamMemberSocialMediaDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class TeamMemberSocialMediaController : Controller
    {
        private readonly DynamicConsume<ResultTeamMemberSocialMediaDto> _resultTeamMemberSocialMedia;
        private readonly DynamicConsume<UpdateTeamMemberSocialMediaDto> _updateTeamMemberSocialMedia;
        private readonly DynamicConsume<CreateTeamMemberSocialMediaDto> _createTeamMemberSocialMedia;
        private readonly DynamicConsume<object> _objectTeamMemberSocialMedia;

        public TeamMemberSocialMediaController(DynamicConsume<ResultTeamMemberSocialMediaDto> resultTeamMemberSocialMedia, DynamicConsume<UpdateTeamMemberSocialMediaDto> updateTeamMemberSocialMedia, DynamicConsume<CreateTeamMemberSocialMediaDto> createTeamMemberSocialMedia, DynamicConsume<object> objectTeamMemberSocialMedia)
        {
            _resultTeamMemberSocialMedia = resultTeamMemberSocialMedia;
            _updateTeamMemberSocialMedia = updateTeamMemberSocialMedia;
            _createTeamMemberSocialMedia = createTeamMemberSocialMedia;
            _objectTeamMemberSocialMedia = objectTeamMemberSocialMedia;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultTeamMemberSocialMedia.GetListAsync("TeamMemberSocialMedias/GetTeamMemberSocialMedia");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateTeamMemberSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTeamMemberSocialMedia(CreateTeamMemberSocialMediaDto dto)
        {
            var result = await _createTeamMemberSocialMedia.PostAsync("TeamMemberSocialMedias", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateTeamMemberSocialMedia(int id)
        {
            var values = await _updateTeamMemberSocialMedia.GetByIdAsync("TeamMemberSocialMedias/GetTeamMemberSocialMediaById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTeamMemberSocialMedia(UpdateTeamMemberSocialMediaDto dto)
        {
            var result = await _updateTeamMemberSocialMedia.PutAsync("TeamMemberSocialMedias/UpdateTeamMemberSocialMedia", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteTeamMemberSocialMedia(int id)
        {
            var result = await _objectTeamMemberSocialMedia.DeleteAsync("TeamMemberSocialMedias/DeleteTeamMemberSocialMedia", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
