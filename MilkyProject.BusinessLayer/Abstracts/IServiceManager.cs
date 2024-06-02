using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Abstracts
{
    public interface IServiceManager
    {
        IAboutUsService AboutUsService { get; }
        IAboutUsServiceService AboutUsServiceService { get; }
        IBusinessHourService BusinessHourService { get; }
        IContactService ContactService { get; }
        IGalleryService GalleryService { get; }
        IMessageService MessageService { get; }
        IOurServiceService OurServiceService { get; }
        IPageBannerService PageBannerService { get; }
        IProductService ProductService { get; }
        ISliderService SliderService { get; }
        ISocialMediaService SocialMediaService { get; }
        ITeamMemberService TeamMemberService { get; }
        ITeamMemberSocialMediaService TeamMemberSocialMediaService { get; }
        ITestimonialService TestimonialService { get; }
        IWhyUsService WhyUsService { get; }
        IWhyUsDetailService WhyUsDetailService { get; }
        INewsletterService NewsletterService { get; }

    }
}
