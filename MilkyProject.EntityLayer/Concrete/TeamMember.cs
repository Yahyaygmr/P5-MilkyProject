﻿using System;
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
        public string? ImageUrl { get; set; }
        public bool Status { get; set; }
        public List<TeamMemberSocialMedia> TeamMemberSocialMedias { get; set; }

    }
}
