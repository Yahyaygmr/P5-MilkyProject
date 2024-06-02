using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.ProductDtos;
using MilkyProject.DtoLayer.TeamMemberDtos;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Models;
using System.Drawing.Text;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutTeamComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultTeamMemmberDto2> _dynamicConsumeResultTeamMember;

        public LayoutTeamComponentPartial(DynamicConsume<ResultTeamMemmberDto2> dynamicConsumeResultTeamMember)
        {
            _dynamicConsumeResultTeamMember = dynamicConsumeResultTeamMember;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResultTeamMember.GetListAsync("TeamMembers/GetTeamMemberWithSocialMedias");

            List<ResultTeamMemmberDto2> members = new List<ResultTeamMemmberDto2>();

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
