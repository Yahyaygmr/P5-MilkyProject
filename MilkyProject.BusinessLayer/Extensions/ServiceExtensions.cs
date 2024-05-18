using Microsoft.Extensions.DependencyInjection;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.BusinessLayer.Concretes;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();

            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<ISliderDal, EfSliderDal>();
            services.AddScoped<ISliderService, SliderManager>();

            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<IAboutUsDal, EfAboutUsDal>();
            services.AddScoped<IAboutUsService, AboutUsManager>();

            services.AddScoped<IAboutUsServiceDal, EfAboutUsServiceDal>();
            services.AddScoped<IAboutUsServiceService, AboutUsServiceManager>();

            services.AddScoped<IBusinessHourDal, EfBusinessHourDal>();
            services.AddScoped<IBusinessHourService, BusinessHourManager>();

            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IGalleryDal, EfGalleryDal>();
            services.AddScoped<IGalleryService, GalleryManager>();

            services.AddScoped<IMessageDal, EfMessageDal>();
            services.AddScoped<IMessageService, MessageManager>();

            services.AddScoped<IOurServiceDal, EfOurServiceDal>();
            services.AddScoped<IOurServiceService, OurServiceManager>();

            services.AddScoped<IPageBannerDal, EfPageBannerDal>();
            services.AddScoped<IPageBannerService, PageBannerManager>();

            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();

            services.AddScoped<ITeamMemberDal, EfTeamMemberDal>();
            services.AddScoped<ITeamMemberService, TeamMemberManager>();

            services.AddScoped<ITeamMemberSocialMediaDal, EfTeamMemberSocialMediaDal>();
            services.AddScoped<ITeamMemberSocialMediaService, TeamMemberSocialMediaManager>();

            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ITestimonialService, TestimonialManager>();

            services.AddScoped<IWhyUsDal, EfWhyUsDal>();
            services.AddScoped<IWhyUsService, WhyUsManager>();

            services.AddScoped<IWhyUsDetailDal, EfWhyUsDetailDal>();
            services.AddScoped<IWhyUsDetailService, WhyUsDetailManager>();

        }
    }
}
