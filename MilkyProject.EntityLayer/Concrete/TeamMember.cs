using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class TeamMember
    {
        public int TeamMemberId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public int TeamMemberSocialMediaId { get; set; }
        public bool Status { get; set; }
        public TeamMemberSocialMedia TeamMemberSocialMedia { get; set; }

    }
}
