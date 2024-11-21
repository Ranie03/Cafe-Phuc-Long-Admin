using DAL.Repositories.Recipe;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Recipe
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _repository;
        public RecipeService(IRecipeRepository repository)
        {
            _repository = repository;
        }
        public List<CongThuc> GetRecipeList()
        {
            return _repository.GetRecipeList();
        }
    }
}
