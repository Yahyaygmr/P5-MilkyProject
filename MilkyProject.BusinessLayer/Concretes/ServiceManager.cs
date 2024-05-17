using MilkyProject.BusinessLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Concretes
{
    public class ServiceManager : IServiceManager
    {
        private readonly IAboutUsService _aboutUsService;
        private readonly IAboutUsServiceService _aboutUsServiceService;
        private readonly IBusinessHourService _businessHourService;
        private readonly ICategoryService _categoryService;
        private readonly IContactService _contactService;
        private readonly IGalleryService _galleryService;
        private readonly IMessageService _messageService;
        private readonly IOurServiceService _ourServiceService;
        private readonly IPageBannerService _pageBannerService;
        private readonly IProductService _productService;
        private readonly ISliderService _sliderService;
        private readonly ISocialMediaService _socialMediaService;
        private readonly ITeamMemberService _teamMemberService;
        private readonly ITeamMemberSocialMediaService _teamMemberSocialMediaService;
        private readonly ITestimonialService _testimonialService;
        private readonly IWhyUsDetailService _whyUsDetailService;
        private readonly IWhyUsService _whyUsService;

        public ServiceManager(IAboutUsService aboutUsService, IAboutUsServiceService aboutUsServiceService, IBusinessHourService businessHourService, ICategoryService categoryService, IContactService contactService, IGalleryService galleryService, IMessageService messageService, IOurServiceService ourServiceService, IPageBannerService pageBannerService, IProductService productService, ISliderService sliderService, ISocialMediaService socialMediaService, ITeamMemberService teamMemberService, ITeamMemberSocialMediaService teamMemberSocialMediaService, ITestimonialService testimonialService, IWhyUsDetailService whyUsDetailService, IWhyUsService whyUsService)
        {
            _aboutUsService = aboutUsService;
            _aboutUsServiceService = aboutUsServiceService;
            _businessHourService = businessHourService;
            _categoryService = categoryService;
            _contactService = contactService;
            _galleryService = galleryService;
            _messageService = messageService;
            _ourServiceService = ourServiceService;
            _pageBannerService = pageBannerService;
            _productService = productService;
            _sliderService = sliderService;
            _socialMediaService = socialMediaService;
            _teamMemberService = teamMemberService;
            _teamMemberSocialMediaService = teamMemberSocialMediaService;
            _testimonialService = testimonialService;
            _whyUsDetailService = whyUsDetailService;
            _whyUsService = whyUsService;
        }

        public IAboutUsService AboutUsService => _aboutUsService;

        public IAboutUsServiceService AboutUsServiceService => _aboutUsServiceService;

        public IBusinessHourService BusinessHourService => _businessHourService;

        public ICategoryService CategoryService => _categoryService;

        public IContactService ContactService => _contactService;

        public IGalleryService GalleryService => _galleryService;

        public IMessageService MessageService => _messageService;

        public IOurServiceService OurServiceService => _ourServiceService;

        public IPageBannerService PageBannerService => _pageBannerService;

        public IProductService ProductService => _productService;

        public ISliderService SliderService => _sliderService;

        public ISocialMediaService SocialMediaService => _socialMediaService;

        public ITeamMemberService TeamMemberService => _teamMemberService;

        public ITeamMemberSocialMediaService TeamMemberSocialMediaService => _teamMemberSocialMediaService;

        public ITestimonialService TestimonialService => _testimonialService;

        public IWhyUsService WhyUsService => _whyUsService;

        public IWhyUsDetailService WhyUsDetailService => _whyUsDetailService;
    }
}
