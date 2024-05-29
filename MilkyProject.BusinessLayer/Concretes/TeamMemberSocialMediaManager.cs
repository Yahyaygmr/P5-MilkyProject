using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DtoLayer.TeamMemberSocialMediaDtos;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Concretes
{
    public class TeamMemberSocialMediaManager : ITeamMemberSocialMediaService
    {
        private readonly ITeamMemberSocialMediaDal _teamMemberSocialMediaDal;

        public TeamMemberSocialMediaManager(ITeamMemberSocialMediaDal teamMemberSocialMediaDal)
        {
            _teamMemberSocialMediaDal = teamMemberSocialMediaDal;
        }

        public List<TeamMemberSocialMedia> GetSocialMediasByMember(int memberId)
        {
            return _teamMemberSocialMediaDal.GetSocialMediasByMember(memberId);
        }

        public void TDelete(int id)
        {
            _teamMemberSocialMediaDal.Delete(id);
        }

        public TeamMemberSocialMedia TGetById(int id)
        {
            return _teamMemberSocialMediaDal.GetById(id);
        }

        public List<TeamMemberSocialMedia> TGetListAll()
        {
            return _teamMemberSocialMediaDal.GetListAll();
        }

        public void TInsert(TeamMemberSocialMedia entity)
        {
            _teamMemberSocialMediaDal.Insert(entity);
        }

        public void TUpdate(TeamMemberSocialMedia entity)
        {
            _teamMemberSocialMediaDal.Update(entity);
        }
        public void TUpdateAsync(UpdateTeamMemberSocialMediaDto entity)
        {
            _teamMemberSocialMediaDal.UpdateAsync(entity);
        }
    }
}
