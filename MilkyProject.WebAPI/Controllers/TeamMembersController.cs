using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
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
        public IActionResult CreateTeamMember(TeamMember TeamMember)
        {
            _serviceManager.TeamMemberService.TInsert(TeamMember);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateTeamMember")]
        public IActionResult UpdateTeamMember(TeamMember TeamMember)
        {
            _serviceManager.TeamMemberService.TUpdate(TeamMember);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteTeamMember/{id}")]
        public IActionResult DeleteTeamMember(int id)
        {
            _serviceManager.TeamMemberService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
