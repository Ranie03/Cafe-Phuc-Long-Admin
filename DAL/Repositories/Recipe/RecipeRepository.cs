using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Recipe
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public RecipeRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<CongThuc> GetRecipeList()
        {
            return _context.CongThucs.ToList();
        }

    }
}
