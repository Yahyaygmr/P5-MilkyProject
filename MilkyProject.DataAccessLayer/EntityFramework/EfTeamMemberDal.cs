using Microsoft.EntityFrameworkCore;
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
    public class EfTeamMemberDal : GenericRepository<TeamMember>, ITeamMemberDal
    {
        private readonly MilkyContext _context;
        public EfTeamMemberDal(MilkyContext context) : base(context)
        {
            _context = context;
        }

        public List<TeamMember> GetMembersWithSocialMedias()
        {
            return _context.TeamMembers.Include(x=>x.TeamMemberSocialMedias).ToList();
        }
    }
}
