using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DtoLayer.GalleryDtos
{
    public class UpdateGalleryDto
    {
        public int GalleryId { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
