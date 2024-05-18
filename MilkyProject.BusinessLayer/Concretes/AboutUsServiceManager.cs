using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Concretes
{
    public class AboutUsServiceManager : IAboutUsServiceService
    {
        private readonly IAboutUsServiceDal _aboutUsServiceDal;

        public AboutUsServiceManager(IAboutUsServiceDal aboutUsServiceDal)
        {
            _aboutUsServiceDal = aboutUsServiceDal;
        }

        public void TDelete(int id)
        {
            _aboutUsServiceDal.Delete(id);
        }

        public AboutUsService TGetById(int id)
        {
            return _aboutUsServiceDal.GetById(id);
        }

        public List<AboutUsService> TGetListAll()
        {
            return _aboutUsServiceDal.GetListAll();
        }

        public void TInsert(AboutUsService entity)
        {
            _aboutUsServiceDal.Insert(entity);
        }

        public void TUpdate(AboutUsService entity)
        {
            _aboutUsServiceDal.Update(entity);
        }
    }
}
