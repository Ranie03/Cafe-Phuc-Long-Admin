using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Material
{
<<<<<<< Updated upstream
    public class MaterialRepository : IMaterialRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public MaterialRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<NguyenLieu> GetMaterialsList()
=======
    public class MaterialRepository:IMaterialRepository
    {

        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public MaterialRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;

        }
        public List<NguyenLieu> GetMaterialList()
>>>>>>> Stashed changes
        {
            return _context.NguyenLieus.ToList();
        }
    }
}
