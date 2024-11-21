using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public CategoryRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<DanhMuc> GetCategoriesList()
        {
            return _context.DanhMucs.ToList();
        }

    }
}
