using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.WhyUsDetailDtos
{
    public class UpdateWhyUsDetailDto
    {
        public int WhyUsDetailId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
