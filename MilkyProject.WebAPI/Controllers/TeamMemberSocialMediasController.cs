using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.DtoLayer.TeamMemberSocialMediaDtos;
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
        [HttpGet("GetTeamMemberSocialMediaByMember/{id}")]
        public IActionResult GetTeamMemberSocialMediaMember(int id)
        {
            var values = _serviceManager.TeamMemberSocialMediaService.GetSocialMediasByMember(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTeamMemberSocialMedia(CreateTeamMemberSocialMediaDto teamMemberSocialMedia)
        {
            _serviceManager.TeamMemberSocialMediaService.TInsert(new TeamMemberSocialMedia()
            {
                AccountName = teamMemberSocialMedia.AccountName,
                Icon = teamMemberSocialMedia.Icon,
                Status = teamMemberSocialMedia.Status,
                TeamMemberId = teamMemberSocialMedia.TeamMemberId,
                Url = teamMemberSocialMedia.Url,
            });
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateTeamMemberSocialMedia")]
        public IActionResult UpdateTeamMemberSocialMedia(UpdateTeamMemberSocialMediaDto teamMemberSocialMedia)
        {
            var value = _serviceManager.TeamMemberSocialMediaService.TGetById(teamMemberSocialMedia.TeamMemberSocialMediaId);

            value.Status = teamMemberSocialMedia.Status;
            value.Url = teamMemberSocialMedia.Url;
            value.AccountName = teamMemberSocialMedia.AccountName;
            value.Icon = teamMemberSocialMedia.Icon;

            _serviceManager.TeamMemberSocialMediaService.TUpdate(value);
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
