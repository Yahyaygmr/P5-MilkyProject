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
    public class NewsletterManager : INewsletterService
    {
        private readonly INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Newsletter TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> TGetListAll()
        {
            return _newsletterDal.GetListAll();
        }

        public void TInsert(Newsletter entity)
        {
            _newsletterDal.Insert(entity);
        }

        public void TUpdate(Newsletter entity)
        {
            throw new NotImplementedException();
        }
    }
}
