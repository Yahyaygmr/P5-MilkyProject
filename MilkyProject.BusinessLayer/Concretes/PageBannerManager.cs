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
    public class PageBannerManager : IPageBannerService
    {
        private readonly IPageBannerDal _pageBannerDal;

        public PageBannerManager(IPageBannerDal pageBannerDal)
        {
            _pageBannerDal = pageBannerDal;
        }

        public void TDelete(int id)
        {
            _pageBannerDal.Delete(id);
        }

        public PageBanner TGetById(int id)
        {
            return _pageBannerDal.GetById(id);
        }

        public List<PageBanner> TGetListAll()
        {
            return _pageBannerDal.GetListAll();
        }

        public void TInsert(PageBanner entity)
        {
            _pageBannerDal.Insert(entity);
        }

        public void TUpdate(PageBanner entity)
        {
            _pageBannerDal.Update(entity);
        }
    }
}
