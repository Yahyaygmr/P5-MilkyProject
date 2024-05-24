using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.TeamMemberDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class TeamMemberController : Controller
    {
        private readonly DynamicConsume<ResultTeamMemberDto> _resultTeamMember;
        private readonly DynamicConsume<UpdateTeamMemberDto> _updateTeamMember;
        private readonly DynamicConsume<CreateTeamMemberDto> _createTeamMember;
        private readonly DynamicConsume<object> _objectTeamMember;

        public TeamMemberController(DynamicConsume<ResultTeamMemberDto> resultTeamMember, DynamicConsume<UpdateTeamMemberDto> updateTeamMember, DynamicConsume<CreateTeamMemberDto> createTeamMember, DynamicConsume<object> objectTeamMember)
        {
            _resultTeamMember = resultTeamMember;
            _updateTeamMember = updateTeamMember;
            _createTeamMember = createTeamMember;
            _objectTeamMember = objectTeamMember;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultTeamMember.GetListAsync("TeamMembers/GetTeamMember");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateTeamMember()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTeamMember(CreateTeamMemberDto dto)
        {
            var result = await _createTeamMember.PostAsync("TeamMembers", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateTeamMember(int id)
        {
            var values = await _updateTeamMember.GetByIdAsync("TeamMembers/GetTeamMemberById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTeamMember(UpdateTeamMemberDto dto)
        {
            var result = await _updateTeamMember.PutAsync("TeamMembers/UpdateTeamMember", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteTeamMember(int id)
        {
            var result = await _objectTeamMember.DeleteAsync("TeamMembers/DeleteTeamMember", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
