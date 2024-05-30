using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.AboutUsServiceDtos;
using MilkyProject.DtoLayer.SliderDtos;
using MilkyProject.WebUI.Models;
using Newtonsoft.Json.Linq;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutAboutServiceComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultAboutUsServiceDto> _dynamicConsumeResultAboutUsService;

        public LayoutAboutServiceComponentPartial(DynamicConsume<ResultAboutUsServiceDto> dynamicConsumeResultAboutUsService)
        {
            _dynamicConsumeResultAboutUsService = dynamicConsumeResultAboutUsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResultAboutUsService.GetListAsync("AboutUsServices/GetAboutUsService");

            List<ResultAboutUsServiceDto> service = new List<ResultAboutUsServiceDto>();
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status)
                {
                    service.Add(values[i]);
                }
            }
            return View(service);
        }
    }
}
