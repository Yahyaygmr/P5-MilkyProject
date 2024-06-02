using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.ContactDtos;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutPageBannerComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<PageBanner> _dynamicConsumeContact;

        public LayoutPageBannerComponentPartial(DynamicConsume<PageBanner> dynamicConsumeContact)
        {
            _dynamicConsumeContact = dynamicConsumeContact;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeContact.GetListAsync("PageBanners/GetPageBanner");

            return View(values);
        }
    }
}
