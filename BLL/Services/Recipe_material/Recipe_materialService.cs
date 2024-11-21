using DAL.Repositories.Recipe_material;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Recipe_material
{
    public class Recipe_materialService : IRecipe_materialService
    {
        private readonly IRecipe_materialRepository _repository;
        public Recipe_materialService(IRecipe_materialRepository repository)
        { 
            _repository = repository; 
        }
        public List<CongThuc_NguyenLieu> GetRecipe_materialsList()
        {
            return _repository.GetRecipe_materialsList();
        }
    }
}
