using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.AboutUsServiceDtos;
using MilkyProject.DtoLayer.WhyUsDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutWhyUsComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultWhyUsDto> _dynamicConsumeResultWhyUs;

        public LayoutWhyUsComponentPartial(DynamicConsume<ResultWhyUsDto> dynamicConsumeResultWhyUs)
        {
            _dynamicConsumeResultWhyUs = dynamicConsumeResultWhyUs;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResultWhyUs.GetListAsync("WhyUses/GetWhyUs");

            return View(values);

        }
    }
}
