using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.OurServiceDtos;
using MilkyProject.DtoLayer.WhyUsDetailDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutServiceComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultOurServiceDto> _dynamicConsumeResultOurService;

        public LayoutServiceComponentPartial(DynamicConsume<ResultOurServiceDto> dynamicConsumeResultOurService)
        {
            _dynamicConsumeResultOurService = dynamicConsumeResultOurService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResultOurService.GetListAsync("OurServices/GetOurService");

            List<ResultOurServiceDto> services = new List<ResultOurServiceDto>();

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status)
                {
                    services.Add(values[i]);
                }
            }
            return View(services);
        }
    }
}
