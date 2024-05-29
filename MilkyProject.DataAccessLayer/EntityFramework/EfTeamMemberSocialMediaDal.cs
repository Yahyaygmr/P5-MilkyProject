using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DataAccessLayer.Repositories;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.EntityFramework
{
    public class EfTeamMemberSocialMediaDal : GenericRepository<TeamMemberSocialMedia>, ITeamMemberSocialMediaDal
    {
        private readonly MilkyContext _context;
        public EfTeamMemberSocialMediaDal(MilkyContext context) : base(context)
        {
            _context = context;
        }

        public List<TeamMemberSocialMedia> GetSocialMediasByMember(int memberId)
        {
            return _context.TeamMemberSocialMedias
                .Where(x=> x.TeamMemberId == memberId)
                .ToList();
        }
    }
}
