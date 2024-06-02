using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.BusinessHourDtos;
using MilkyProject.DtoLayer.SocialMediaDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.FooterViewComponents
{
    public class FooterBusinessHourComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultBusinessHourDto> _dynamicConsumeBusinessHour;

        public FooterBusinessHourComponentPartial(DynamicConsume<ResultBusinessHourDto> dynamicConsumeBusinessHour)
        {
            _dynamicConsumeBusinessHour = dynamicConsumeBusinessHour;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeBusinessHour.GetListAsync("BusinessHours/GetBusinessHour");

            List<ResultBusinessHourDto> hour = new List<ResultBusinessHourDto>();

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status)
                {
                    hour.Add(values[i]);
                }
            }
            return View(hour);
        }
    }
}
