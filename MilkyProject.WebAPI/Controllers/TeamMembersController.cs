using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.DtoLayer.TeamMemberDtos;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public TeamMembersController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetTeamMember")]
        public IActionResult GetTeamMember()
        {
            var values = _serviceManager.TeamMemberService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetTeamMemberById/{id}")]
        public IActionResult GetTeamMemberById(int id)
        {
            var values = _serviceManager.TeamMemberService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTeamMember(CreateTeamMemberDto dto)
        {
            _serviceManager.TeamMemberService.TInsert(new TeamMember()
            {
                NameSurname=dto.NameSurname,
                Status = dto.Status,
                Title = dto.Title,
            });
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateTeamMember")]
        public IActionResult UpdateTeamMember(UpdateTeamMemberDto dto)
        {
            _serviceManager.TeamMemberService.TUpdate(new TeamMember()
            {
                TeamMemberId = dto.TeamMemberId,
                NameSurname = dto.NameSurname,
                Status = dto.Status,
                Title = dto.Title,
            });
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteTeamMember/{id}")]
        public IActionResult DeleteTeamMember(int id)
        {
            _serviceManager.TeamMemberService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
        [HttpGet("GetTeamMemberWithSocialMedias")]
        public IActionResult GetTeamMemberWithSocialMedias()
        {
            var values = _serviceManager.TeamMemberService.GetMembersWithSocialMedias();
            return Ok(values);
        }
    }
}
