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
    public class OurServiceManager : IOurServiceService
    {
        private readonly IOurServiceDal _ourServiceDal;

        public OurServiceManager(IOurServiceDal ourServiceDal)
        {
            _ourServiceDal = ourServiceDal;
        }

        public void TDelete(int id)
        {
            _ourServiceDal.Delete(id);
        }

        public OurService TGetById(int id)
        {
            return _ourServiceDal.GetById(id);
        }

        public List<OurService> TGetListAll()
        {
            return _ourServiceDal.GetListAll();
        }

        public void TInsert(OurService entity)
        {
            _ourServiceDal.Insert(entity);
        }

        public void TUpdate(OurService entity)
        {
            _ourServiceDal.Update(entity);
        }
    }
}
