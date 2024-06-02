using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class TeamMemberSocialMedia
    {
        public int TeamMemberSocialMediaId { get; set; }
        public string AccountName { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public bool Status { get; set; }
        public int TeamMemberId { get; set; }
        public TeamMember TeamMember { get; set; }
    }
}
