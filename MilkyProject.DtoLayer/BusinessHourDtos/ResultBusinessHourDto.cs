using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.BusinessHourDtos
{
    public class ResultBusinessHourDto
    {
        public int BusinessHourId { get; set; }
        public string Day { get; set; }
        public string Hours { get; set; }
        public bool Status { get; set; }
    }
}
