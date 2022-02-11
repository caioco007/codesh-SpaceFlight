using SpaceFlight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceFlight.Interface.Service
{
    public interface IArticlesService
    {
        public Task<IEnumerable<ArticlesModel>> GetAllAsync();
        public Task<ArticlesModel> GetByIdAsync(int id);
        public Task<ArticlesModel> CreateAsync(ArticlesModel articles);
        public Task<ArticlesModel> UpdateAsync(ArticlesModel articles);
        public Task DeleteAsync(int id);
        public Task<ArticlesModel> IsExistBdAsync(string title, int id);
    }
}
