using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.ContactDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.FooterViewComponents
{
    public class FooterAdressComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultContactDto> _dynamicConsumeContact;

        public FooterAdressComponentPartial(DynamicConsume<ResultContactDto> dynamicConsumeContact)
        {
            _dynamicConsumeContact = dynamicConsumeContact;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeContact.GetListAsync("Contacts/GetContact");

            return View(values);
        }
    }
}
