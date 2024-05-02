using Microsoft.EntityFrameworkCore;
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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly MilkyContext _context;
        public EfProductDal(MilkyContext context) : base(context)
        {
            _context= context;
        }

        public List<Product> GetProductsWithCategory()
        {
            //var values = _context.Products
            //    .Select(p => new Product
            //    {
            //        NewPrice = p.NewPrice,
            //        Name = p.Name,
            //        CategoryId = p.CategoryId,
            //        ImageUrl = p.ImageUrl,
            //        OldPrice = p.OldPrice,
            //        Status = p.Status,
            //        ProductId = p.ProductId,
            //        Category = new Category { Name = p.Category.Name }
            //    }).ToList();
            //return values;
            var values = _context.Products
                .Include(p => p.Category)
                .ToList();
            return values;
        }
    }
}
