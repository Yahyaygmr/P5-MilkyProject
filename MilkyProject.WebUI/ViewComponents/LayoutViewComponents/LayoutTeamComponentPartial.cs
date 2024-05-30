using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.ProductDtos;
using MilkyProject.DtoLayer.TeamMemberDtos;
using MilkyProject.WebUI.Models;
using System.Drawing.Text;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutTeamComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultTeamMemberDto> _dynamicConsumeResultTeamMemberDto;

        public LayoutTeamComponentPartial(DynamicConsume<ResultTeamMemberDto> dynamicConsumeResultTeamMemberDto)
        {
            _dynamicConsumeResultTeamMemberDto = dynamicConsumeResultTeamMemberDto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResultTeamMemberDto.GetListAsync("");

            List<ResultTeamMemberDto> members = new List<ResultTeamMemberDto>();

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status)
                {
                    members.Add(values[i]);
                }
            }
            return View(members);
        }
    }
}
