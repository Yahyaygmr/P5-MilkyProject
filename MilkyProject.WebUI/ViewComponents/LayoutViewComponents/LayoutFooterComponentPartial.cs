﻿using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.SocialMediaDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutFooterComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultSocialMediaDto> _dynamicConsumeResultSocialMediaDto;

        public LayoutFooterComponentPartial(DynamicConsume<ResultSocialMediaDto> dynamicConsumeResultSocialMediaDto)
        {
            _dynamicConsumeResultSocialMediaDto = dynamicConsumeResultSocialMediaDto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResultSocialMediaDto.GetListAsync("SocialMedias/GetSocialMedia");

            List<ResultSocialMediaDto> media = new List<ResultSocialMediaDto>();

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status)
                {
                    media.Add(values[i]);
                }
            }
            return View(media);
        }
    }
}
