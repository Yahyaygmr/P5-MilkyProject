using MilkyProject.DtoLayer.TeamMemberSocialMediaDtos;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Abstracts
{
    public interface ITeamMemberSocialMediaService : IGenericService<TeamMemberSocialMedia>
    {
        List<TeamMemberSocialMedia> GetSocialMediasByMember(int memberId);
        void TUpdateAsync(UpdateTeamMemberSocialMediaDto entity);
    }
}
