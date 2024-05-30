using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.AboutUsDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutAboutComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultAboutUsDto> _dynamicConsumeResultAboutUs;

        public LayoutAboutComponentPartial(DynamicConsume<ResultAboutUsDto> dynamicConsumeResultAboutUs)
        {
            _dynamicConsumeResultAboutUs = dynamicConsumeResultAboutUs;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResultAboutUs.GetListAsync("AboutUses/GetAboutUs");
            return View(values);
        }
    }
}
