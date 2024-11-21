using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Recipe_material
{
    public interface IRecipe_materialRepository
    {
        List<CongThuc_NguyenLieu> GetRecipe_materialsList();
    }
}
