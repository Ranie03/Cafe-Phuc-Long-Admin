using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Recipe
{
    public interface IRecipeRepository
    {
        List<CongThuc> GetRecipeList();

    }
}
