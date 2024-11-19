using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Product
{
    public class ProductRepository : IProductRepository
    {
        public readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public ProductRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;
        }

        public List<SanPham> GetProductList()
        {
            return _context.SanPhams.ToList();
        }
        public List<SanPham> GetProductByCategoryId(string categoryId)
        {
            return _context.SanPhams
                .Where(prod => prod.maDM == categoryId)
                .ToList();
        }
    }
}
