using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Size
{
    public class SizeRepository : ISizeRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public SizeRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<DTO.Size> GetSizeList()
        {
            return _context.Sizes.ToList();
        }
        
    }
}
