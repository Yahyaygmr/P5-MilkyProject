using Microsoft.EntityFrameworkCore;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DataAccessLayer.Repositories;
using MilkyProject.DtoLayer.TeamMemberSocialMediaDtos;
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
        public async Task UpdateAsync(UpdateTeamMemberSocialMediaDto teamMemberSocialMedia)
        {
            _context.Attach(teamMemberSocialMedia);
            _context.Entry(teamMemberSocialMedia).State = EntityState.Modified;

            bool saveFailed;
            do
            {
                saveFailed = false;
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;
                    var entry = ex.Entries.Single();
                    var databaseValues = await entry.GetDatabaseValuesAsync();
                    if (databaseValues == null)
                    {
                        throw new Exception("The entity being updated has been deleted.");
                    }

                    var databaseEntity = databaseValues.ToObject();
                    // Merge the database values into the entity
                    entry.OriginalValues.SetValues(databaseValues);
                }
            } while (saveFailed);
        }
    }
}
