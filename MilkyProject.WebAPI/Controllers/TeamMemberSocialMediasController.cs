using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMemberSocialMediasController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public TeamMemberSocialMediasController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetTeamMemberSocialMedia")]
        public IActionResult GetTeamMemberSocialMedia()
        {
            var values = _serviceManager.TeamMemberSocialMediaService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetTeamMemberSocialMediaById/{id}")]
        public IActionResult GetTeamMemberSocialMediaById(int id)
        {
            var values = _serviceManager.TeamMemberSocialMediaService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTeamMemberSocialMedia(TeamMemberSocialMedia teamMemberSocialMedia)
        {
            _serviceManager.TeamMemberSocialMediaService.TInsert(teamMemberSocialMedia);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateTeamMemberSocialMedia")]
        public IActionResult UpdateTeamMemberSocialMedia(TeamMemberSocialMedia teamMemberSocialMedia)
        {
            _serviceManager.TeamMemberSocialMediaService.TUpdate(teamMemberSocialMedia);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteTeamMemberSocialMedia/{id}")]
        public IActionResult DeleteTeamMemberSocialMedia(int id)
        {
            _serviceManager.TeamMemberSocialMediaService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
