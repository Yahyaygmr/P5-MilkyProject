using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.GalleryDtos;
using MilkyProject.DtoLayer.ProductDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutProductComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultProductDto> _dynamicConsumeResultProductDto;

        public LayoutProductComponentPartial(DynamicConsume<ResultProductDto> dynamicConsumeResultProductDto)
        {
            _dynamicConsumeResultProductDto = dynamicConsumeResultProductDto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResultProductDto.GetListAsync("Products");
            List<ResultProductDto> products = new List<ResultProductDto>();

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status)
                {
                    products.Add(values[i]);
                }
            }
            return View(products);
        }
    }
}
