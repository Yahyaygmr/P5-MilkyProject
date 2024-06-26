﻿using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.ContactDtos;
using MilkyProject.DtoLayer.TestimonialDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.ContactViewComponents
{
    
    public class ContactAdressComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultContactDto> _dynamicConsumeContact;

        public ContactAdressComponentPartial(DynamicConsume<ResultContactDto> dynamicConsumeContact)
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
