using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.GalleryDtos;
using MilkyProject.DtoLayer.OurServiceDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    
    public class LayoutGalleryComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultGalleryDto> _dynamicConsumeResultGallery;

        public LayoutGalleryComponentPartial(DynamicConsume<ResultGalleryDto> dynamicConsumeResultGallery)
        {
            _dynamicConsumeResultGallery = dynamicConsumeResultGallery;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResultGallery.GetListAsync("Galleries/GetGallery");
            List<ResultGalleryDto> gallery = new List<ResultGalleryDto>();

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status)
                {
                    gallery.Add(values[i]);
                }
            }
            return View(gallery);
        }
    }
}
