using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.SliderDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutSliderComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultSliderDto> _resultSliderDto;

        public LayoutSliderComponentPartial(DynamicConsume<ResultSliderDto> resultSliderDto)
        {
            _resultSliderDto = resultSliderDto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values =await _resultSliderDto.GetListAsync("Sliders/GetSlider");
            List<ResultSliderDto> slider = new List<ResultSliderDto>();
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status)
                {
                    slider.Add(values[i]);
                }
            }
            return View(slider);
        }
    }
}
