using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Recipe_material
{
    public interface IRecipe_materialService
    {
        List<CongThuc_NguyenLieu> GetRecipe_materialsList();
    }
}
