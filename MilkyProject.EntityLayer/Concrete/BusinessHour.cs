using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class BusinessHour
    {
        public int BusinessHourId { get; set; }
        public string Day { get; set; }
        public string Hours { get; set; }
        public bool Status { get; set; }
    }
}
