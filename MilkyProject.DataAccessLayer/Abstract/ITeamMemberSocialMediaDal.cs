using MilkyProject.DtoLayer.TeamMemberSocialMediaDtos;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.Abstract
{
    public interface ITeamMemberSocialMediaDal : IGenericDal<TeamMemberSocialMedia>
    {
        List<TeamMemberSocialMedia> GetSocialMediasByMember(int memberId);
        Task UpdateAsync(UpdateTeamMemberSocialMediaDto teamMemberSocialMedia);
    }
}
