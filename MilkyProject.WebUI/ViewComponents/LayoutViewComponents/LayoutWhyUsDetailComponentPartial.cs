using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.AboutUsServiceDtos;
using MilkyProject.DtoLayer.WhyUsDetailDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutWhyUsDetailComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultWhyUsDetailDto> _dynamicConsumeResultWhyUsDetail;
        public LayoutWhyUsDetailComponentPartial(DynamicConsume<ResultWhyUsDetailDto> dynamicConsumeResultWhyUsDetail)
        {
            _dynamicConsumeResultWhyUsDetail = dynamicConsumeResultWhyUsDetail;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResultWhyUsDetail.GetListAsync("WhyUsDetails/GetWhyUsDetail");

            List<ResultWhyUsDetailDto> detail = new List<ResultWhyUsDetailDto>();

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status)
                {
                    detail.Add(values[i]);
                }
            }
            return View(detail);
        }
    }
}
