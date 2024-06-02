using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Abstracts
{
    public interface ITeamMemberService : IGenericService<TeamMember>
    {
        List<TeamMember> GetMembersWithSocialMedias();
    }
}
