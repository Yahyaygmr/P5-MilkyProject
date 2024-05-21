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
    public class WhyUsManager : IWhyUsService
    {
        private readonly IWhyUsDal _whyUsDal;

        public WhyUsManager(IWhyUsDal whyUsDal)
        {
            _whyUsDal = whyUsDal;
        }

        public void TDelete(int id)
        {
            _whyUsDal.Delete(id);
        }

        public WhyUs TGetById(int id)
        {
            return _whyUsDal.GetById(id);
        }

        public List<WhyUs> TGetListAll()
        {
            return _whyUsDal.GetListAll();
        }

        public void TInsert(WhyUs entity)
        {
            _whyUsDal.Insert(entity);
        }

        public void TUpdate(WhyUs entity)
        {
            _whyUsDal.Update(entity);
        }
    }
}
