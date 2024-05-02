using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DataAccessLayer.Repositories;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly MilkyContext _context;
        public EfCategoryDal(MilkyContext context) : base(context)
        {
            _context = context;
        }

        public int GetCategoryCount()
        {
            return _context.Categories.Count();
        }
    }
}
