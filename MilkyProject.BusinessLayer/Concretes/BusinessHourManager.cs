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
    public class BusinessHourManager : IBusinessHourService
    {
        private readonly IBusinessHourDal _businessHourDal;

        public BusinessHourManager(IBusinessHourDal businessHourDal)
        {
            _businessHourDal = businessHourDal;
        }

        public void TDelete(int id)
        {
            _businessHourDal.Delete(id);
        }

        public BusinessHour TGetById(int id)
        {
            return _businessHourDal.GetById(id);
        }

        public List<BusinessHour> TGetListAll()
        {
            return _businessHourDal.GetListAll();
        }

        public void TInsert(BusinessHour entity)
        {
            _businessHourDal.Insert(entity);
        }

        public void TUpdate(BusinessHour entity)
        {
            _businessHourDal.Update(entity);
        }
    }
}
