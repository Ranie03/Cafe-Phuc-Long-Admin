using DAL.Repositories.Category;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        public CategoryService(ICategoryRepository repository)
        { 
            _repository = repository; 
        }
        public List<DanhMuc> GetCategoriesList()
        {
            return _repository.GetCategoriesList();
        }
    }
}
