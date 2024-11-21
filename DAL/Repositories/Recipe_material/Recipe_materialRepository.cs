using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Recipe_material
{
    public class Recipe_materialRepository : IRecipe_materialRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public Recipe_materialRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<CongThuc_NguyenLieu> GetRecipe_materialsList()
        {
            return _context.CongThuc_NguyenLieus.ToList();
        }
    }
}
