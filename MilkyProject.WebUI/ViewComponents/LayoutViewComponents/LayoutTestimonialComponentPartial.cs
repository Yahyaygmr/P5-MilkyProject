using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.TeamMemberDtos;
using MilkyProject.DtoLayer.TestimonialDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutTestimonialComponentPartial : ViewComponent
    {
        private readonly DynamicConsume<ResultTestimonialDto> _dynamicConsumeResutTestimonial;

        public LayoutTestimonialComponentPartial(DynamicConsume<ResultTestimonialDto> dynamicConsumeResutTestimonial)
        {
            _dynamicConsumeResutTestimonial = dynamicConsumeResutTestimonial;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dynamicConsumeResutTestimonial.GetListAsync("Testimonials/GetTestimonial");

            List<ResultTestimonialDto> testimonials = new List<ResultTestimonialDto>();

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status)
                {
                    testimonials.Add(values[i]);
                }
            }
            return View(testimonials);
        }
    }
}
