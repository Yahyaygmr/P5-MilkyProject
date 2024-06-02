using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Concretes
{
    public class TeamMemberManager : ITeamMemberService
    {
        private readonly ITeamMemberDal _teamMemberDal;

        public TeamMemberManager(ITeamMemberDal teamMemberDal)
        {
            _teamMemberDal = teamMemberDal;
        }

        public List<TeamMember> GetMembersWithSocialMedias()
        {
            return _teamMemberDal.GetMembersWithSocialMedias();
        }

        public void TDelete(int id)
        {
            _teamMemberDal.Delete(id);
        }

        public TeamMember TGetById(int id)
        {
            return _teamMemberDal.GetById(id);
        }

        public List<TeamMember> TGetListAll()
        {
            return _teamMemberDal.GetListAll();
        }

        public void TInsert(TeamMember entity)
        {
            _teamMemberDal.Insert(entity);
        }

        public void TUpdate(TeamMember entity)
        {
            _teamMemberDal.Update(entity);
        }
    }
}
