using Microsoft.EntityFrameworkCore;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.Context
{
    public class MilkyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-4QIIH5S;database=MilkyDb;integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<AboutUsService> AboutUsServices { get; set; }
        public DbSet<BusinessHour> BusinessHours { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<OurService> OurServices { get; set; }
        public DbSet<PageBanner> PageBanners { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<TeamMemberSocialMedia> TeamMemberSocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WhyUs> WhyUses { get; set; }
        public DbSet<WhyUsDetail> WhyUsDetails { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
