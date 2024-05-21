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
    public class WhyUsDetailManager : IWhyUsDetailService
    {
        private readonly IWhyUsDetailDal _whyUsDetailDal;

        public WhyUsDetailManager(IWhyUsDetailDal whyUsDetailDal)
        {
            _whyUsDetailDal = whyUsDetailDal;
        }

        public void TDelete(int id)
        {
            _whyUsDetailDal.Delete(id);
        }

        public WhyUsDetail TGetById(int id)
        {
            return _whyUsDetailDal.GetById(id);
        }

        public List<WhyUsDetail> TGetListAll()
        {
            return _whyUsDetailDal.GetListAll();
        }

        public void TInsert(WhyUsDetail entity)
        {
            _whyUsDetailDal.Insert(entity);
        }

        public void TUpdate(WhyUsDetail entity)
        {
            _whyUsDetailDal.Update(entity);
        }
    }
}
