using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.SliderDtos
{
    public class ResultSliderDto
    {
        public int SliderId { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description1 { get; set; }
        public string? Description2 { get; set; }
        public bool Status { get; set; }
    }
}
