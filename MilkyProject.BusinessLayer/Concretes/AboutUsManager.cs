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

    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public AboutUs TGetById(int id)
        {
            return _aboutUsDal.GetById(id);
        }

        public List<AboutUs> TGetListAll()
        {
            return _aboutUsDal.GetListAll();
        }

        public void TInsert(AboutUs entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AboutUs entity)
        {
            _aboutUsDal.Update(entity);
        }
    }
}
