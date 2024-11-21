using DAL.Repositories.Material;
<<<<<<< Updated upstream
=======
using DAL.Repositories.Staff;
>>>>>>> Stashed changes
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< Updated upstream
namespace BLL.Services.Material
{
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository _repository;
        public MaterialService(IMaterialRepository repository)
        { 
            _repository = repository; 
        }
        public List<NguyenLieu> GetMaterialsList()
        {
            return _repository.GetMaterialsList();
        }
=======

namespace BLL.Services.Material
{
    public class MaterialService:IMaterialService
    {
        public readonly IMaterialRepository _repository;
        public MaterialService(IMaterialRepository repository)
        {
            this._repository = repository;
        }
        public List<NguyenLieu> GetMaterialList()
        {
            return _repository.GetMaterialList();
        }

>>>>>>> Stashed changes
    }
}
