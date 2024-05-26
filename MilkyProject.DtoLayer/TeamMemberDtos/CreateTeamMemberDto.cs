using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.TeamMemberDtos
{
    public class CreateTeamMemberDto
    {
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
    }
}
