using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.AboutUsServiceDtos
{
    public class ResultAboutUsServiceDto
    {
        public int AboutUsServiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public bool Status { get; set; }
    }
}
