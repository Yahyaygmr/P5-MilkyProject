﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public bool Status { get; set; }
    }
}
